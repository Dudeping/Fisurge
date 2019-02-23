using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Codeping.Fisurge.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tool split = new Tool(2);

            //if (split.SplitAsync().Result)
            //{
            //    System.Console.WriteLine("ok");
            //}
            //else
            //{
            //    System.Console.WriteLine("fail.");
            //}

            Tool pack = new Tool(AppDomain.CurrentDomain.BaseDirectory);

            if (pack.PackAsync().Result)
            {
                System.Console.WriteLine("ok");
            }
            else
            {
                System.Console.WriteLine("fail.");
            }

            System.Console.ReadKey();
        }
    }

    class Tool
    {
        private readonly int _num = 0;
        private readonly string _dir;

        public Tool(int num)
        {
            _num = num;
        }

        public Tool(string packDir)
        {
            _dir = packDir;
        }

        public async Task<bool> SplitAsync()
        {
            string fileName = "cn_windows_10_business_editions_version_1803_updated_march_2018_x64_dvd_12063730.7z";

            using (FileStream rs = new FileStream(fileName, FileMode.Open))
            {
                byte[] buffer = new byte[1024];

                for (int i = 0; i < _num; i++)
                {
                    System.Console.WriteLine($"split to file { fileName } begin.");

                    using (FileStream ws = new FileStream($"chip{i}_{fileName}.7z", FileMode.CreateNew))
                    {
                        System.Console.WriteLine($"{i + 1} / {_num} split chip{i}.7z new...");

                        while (true)
                        {
                            int count = await rs.ReadAsync(buffer, 0, buffer.Length);

                            await ws.WriteAsync(buffer, 0, count);

                            if (i < _num - 1)
                            {
                                if (ws.Length > rs.Length / _num)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (count < 1024)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                System.Console.WriteLine("split success.");
            }

            return true;
        }

        public async Task<bool> PackAsync()
        {
            DirectoryInfo info = new DirectoryInfo(_dir);

            var fileInfos = info.GetFiles().Where(x => x.Name.StartsWith("chip")).ToArray();

            string fileName = "cn_windows_10_business_editions_version_1803_updated_march_2018_x64_dvd_12063730" + fileInfos[0].Extension;

            using (FileStream ws = new FileStream(fileName, FileMode.CreateNew))
            {
                System.Console.WriteLine($"pack to file {fileName} begin.");

                System.Console.WriteLine($"there has {fileInfos.Length} file to copy.");

                int num = 0;

                foreach (var file in fileInfos)
                {
                    using (FileStream rs = new FileStream(file.FullName, FileMode.Open))
                    {
                        System.Console.WriteLine($" { ++num } / { fileInfos.Length } copy file {file.FullName} now...");
                        await rs.CopyToAsync(ws);
                    }
                }
            }

            System.Console.WriteLine("pack success.");

            return true;
        }
    }
}
