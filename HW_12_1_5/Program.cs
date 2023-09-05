using System;


namespace HW_12_1_5
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<UserInfo> users = new List<UserInfo>();
            users.Add(new UserInfo("Tom123", "Tom", true));
            users.Add(new UserInfo("MiKe_005", "Mike", false));
            users.Add(new UserInfo("Alex__O", "Alex", false));
            users.Add(new UserInfo("AgataSnow", "Agata", true));
            users.Add(new UserInfo("Mr_smith", "Nick", true));

            foreach (UserInfo user in users)
            {
                Console.WriteLine($"Hello, {user.Name}!");
                if (!user.IsPremium)
                    ShowAdvertising.ShowAds();
                Console.WriteLine();
            }

        }

        
    }
}