using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iw6x_server_launcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                try
                {
                    var requestedName = new System.Reflection.AssemblyName(args.Name).Name + ".dll";
                    var asm = System.Reflection.Assembly.GetExecutingAssembly();
                    var resourceName = asm.GetManifestResourceNames()
                        .FirstOrDefault(r => r.EndsWith(requestedName, StringComparison.OrdinalIgnoreCase));
                    if (resourceName == null)
                        return null;
                    using (var stream = asm.GetManifestResourceStream(resourceName))
                    {
                        if (stream == null)
                            return null;
                        var data = new byte[stream.Length];
                        stream.Read(data, 0, data.Length);
                        return System.Reflection.Assembly.Load(data);
                    }
                }
                catch
                {
                    return null;
                }
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
