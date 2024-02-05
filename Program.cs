using System;
using Microsoft.Win32;

namespace RegistryModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                if (key != null)
                {
                    key.SetValue("Hidden", 1, RegistryValueKind.DWord); // Show hidden files
                    key.SetValue("HideFileExt", 0, RegistryValueKind.DWord); // Show file extensions

                    Console.WriteLine("Registry updated successfully.");
                }
                else
                {
                    Console.WriteLine("Registry key not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}