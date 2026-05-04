using System;
using System.Collections.Generic;
using System.Media;
using System.IO;

namespace Ice_Task_2
{
    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<Appointment> appointments = new List<Appointment>();
        static List<WellnessRecord> wellnessRecords = new List<WellnessRecord>();

        static void Main(string[] args)
        {
            PlayAudio();
            DisplayWelcome();
            RunMenu();
        }

        static void PlayAudio()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Audio/welcomeC.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio file could not be played.");
            }
        }

        static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("======================================");
            Console.WriteLine("   CLINIC MANAGEMENT SYSTEM");
            Console.WriteLine("======================================");
            Console.ResetColor();
        }

        static void RunMenu()
        {
            while (true)
            {
                Console.WriteLine("\n***** CLINIC MANAGEMENT MENU *****");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Book Appointment");
                Console.WriteLine("4. View Appointments");
                Console.WriteLine("5. Record Wellness");
                Console.WriteLine("6. View Wellness Records");
                Console.WriteLine("7. Generate Report");
                Console.WriteLine("8. Exit");

                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                try
                {
                    int choice = int.Parse(input);

                    switch (choice)
                    {
                        case 1:
                            RegisterPatient();
                            break;
                        case 2:
                            ViewPatients();
                            break;
                        case 3:
                            BookAppointment();
                            break;
                        case 4:
                            ViewAppointments();
                            break;
                        case 5:
                            RecordWellness();
                            break;
                        case 6:
                            ViewWellness();
                            break;
                        case 7:
                            GenerateReport();
                            break;
                        case 8:
                            Console.WriteLine("Exiting program...");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ResetColor();
                }
            }
        }

        static void RegisterPatient()
        {
            try
            {
                Console.Write("Enter Patient ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                    throw new InvalidInputException("Name cannot be empty.");

                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Patient patient = new Patient
                {
                    PatientID = id,
                    Name = name,
                    Age = age
                };

                patients.Add(patient);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Patient registered successfully!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
        }

        static void ViewPatients()
        {
            Console.WriteLine("\n--- Patient List ---");

            if (patients.Count == 0)
            {
                Console.WriteLine("No patients found.");
                return;
            }

            foreach (var patient in patients)
            {
                patient.DisplayInfo();
            }
        }

        static void BookAppointment()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Date: ");
            string date = Console.ReadLine();

            Appointment appointment = new Appointment
            {
                PatientID = id,
                Date = date
            };

            appointments.Add(appointment);

            Console.WriteLine("Appointment booked successfully!");
        }

        static void ViewAppointments()
        {
            Console.WriteLine("\n--- Appointments ---");

            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments found.");
                return;
            }

            foreach (var appt in appointments)
            {
                appt.Display();
            }
        }

        static void RecordWellness()
        {
            Console.Write("Enter Patient ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Notes: ");
            string notes = Console.ReadLine();

            WellnessRecord record = new WellnessRecord
            {
                PatientID = id,
                Notes = notes
            };

            wellnessRecords.Add(record);

            Console.WriteLine("Wellness record added.");
        }

        static void ViewWellness()
        {
            Console.WriteLine("\n--- Wellness Records ---");

            if (wellnessRecords.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            foreach (var record in wellnessRecords)
            {
                record.Display();
            }
        }

        static void GenerateReport()
        {
            Console.WriteLine("\n--- Clinic Report ---");
            Console.WriteLine($"Total Patients: {patients.Count}");
            Console.WriteLine($"Total Appointments: {appointments.Count}");
            Console.WriteLine($"Total Wellness Records: {wellnessRecords.Count}");
        }
    }
}