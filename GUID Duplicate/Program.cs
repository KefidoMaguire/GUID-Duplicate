using System;

namespace GUID_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("\r\n ___  __    _______   ________ ___  ________  ________  _____ ______   ________  ________  ___  ___  ___  ________  _______      \r\n|\\  \\|\\  \\ |\\  ___ \\ |\\  _____\\\\  \\|\\   ___ \\|\\   __  \\|\\   _ \\  _   \\|\\   __  \\|\\   ____\\|\\  \\|\\  \\|\\  \\|\\   __  \\|\\  ___ \\     \r\n\\ \\  \\/  /|\\ \\   __/|\\ \\  \\__/\\ \\  \\ \\  \\_|\\ \\ \\  \\|\\  \\ \\  \\\\\\__\\ \\  \\ \\  \\|\\  \\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\ \\  \\|\\  \\ \\   __/|    \r\n \\ \\   ___  \\ \\  \\_|/_\\ \\   __\\\\ \\  \\ \\  \\ \\\\ \\ \\  \\\\\\  \\ \\  \\\\|__| \\  \\ \\   __  \\ \\  \\  __\\ \\  \\\\\\  \\ \\  \\ \\   _  _\\ \\  \\_|/__  \r\n  \\ \\  \\\\ \\  \\ \\  \\_|\\ \\ \\  \\_| \\ \\  \\ \\  \\_\\\\ \\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\  \\ \\  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\  \\ \\  \\\\  \\\\ \\  \\_|\\ \\ \r\n   \\ \\__\\\\ \\__\\ \\_______\\ \\__\\   \\ \\__\\ \\_______\\ \\_______\\ \\__\\    \\ \\__\\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\__\\ \\__\\\\ _\\\\ \\_______\\\r\n    \\|__| \\|__|\\|_______|\\|__|    \\|__|\\|_______|\\|_______|\\|__|     \\|__|\\|__|\\|__|\\|_______|\\|_______|\\|__|\\|__|\\|__|\\|_______|\r\n                                                                                                                                 \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n");
            
            //Creates Guid List
            List<Guid> guidList = new List<Guid>();

            //Bool that checks if Guid is duplicated
            bool guidIsDuplicated = false;

            //into to fill the List with 100 Guids because the chance to get a double Guid is very low
            int i = 0;
            
            //Fill the List with 100 Guids
            while (i <= 100)
            {
                guidList.Add(GuidGenerator.GuidGeneratorMethod());
                i++;
            }

            //Iterates trough the list to check if Guid is duplicated
            while (guidIsDuplicated == false)
            {
                //Adds a Guid
                guidList.Add(GuidGenerator.GuidGeneratorMethod());

                //Iterates trough the List
                foreach (var item in guidList)
                {
                    //If the List contains a new Generated GUID the bool is set to true and that means a GUID is doubled
                    if (guidList.Contains(GuidGenerator.GuidGeneratorMethod()))
                        guidIsDuplicated = true;
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("Duplicated GUID was found");
            Console.ReadKey();
        }
    }
}