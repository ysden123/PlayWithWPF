using System.IO;

namespace WpfAppAsync
{
    internal class LongProcess
    {
        public static async Task<string> MakeJob()
        {
            var result = await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                return "Done";
            });
            return result;
        }

        public static async Task<string> MakeJob2()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                return "Done 2";
            });
        }

        public static async Task<string> MakeJob3()
        {
            return await Task.Run(() =>
            {
                EnumerationOptions enumerationOptions = new()
                {
                    RecurseSubdirectories = true
                };
                var result = Directory.EnumerateDirectories(@"D:/Photo/YSPhoto/Images", "*", enumerationOptions);
                return "Done 3";
            });
        }
    }
}
