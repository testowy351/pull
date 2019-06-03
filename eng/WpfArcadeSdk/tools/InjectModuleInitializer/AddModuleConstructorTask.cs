using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace WpfArcadeSdk.Build.Tasks
{
    /// <summary>
    /// Append the supplied module constructor to the supplied IL file.
    /// Using this requires that the DLL has implemented a static class named
    /// ModuleInitializer with a static void Initialize function.  This class
    /// is called from the module initializer.
    /// </summary>
    public class AddModuleConstructorTask : Task
    {
        /// <summary>
        /// The original IL file to manipulate
        /// </summary>
        [Required]
        public string ILFile { get; set; }

        /// <summary>
        /// Contains the IL section referencing mscorlib.
        /// This is inserted if not already present.
        /// </summary>
        [Required]
        public string MsCorLibAssemblySectionIL { get; set; }

        /// <summary>
        /// Contains the IL of the module constructor
        /// </summary>
        [Required]
        public string ModuleConstructorIL { get; set; }

        public override bool Execute()
        {
            try
            {
                var moduleConstructorIL = File.ReadAllText(ModuleConstructorIL);
                var msCorLibAssemblySectionIL = File.ReadAllText(MsCorLibAssemblySectionIL);
                var sourceIL = File.ReadAllText(ILFile);

                using (var outputIL = new StreamWriter(File.Open(ILFile, FileMode.Truncate)))
                {
                    if (Regex.Match(sourceIL, @"\.class.+?ModuleInitializer.+?\.method.+?static.+?Initialize\(\).+?end of class ModuleInitializer", RegexOptions.Singleline) == Match.Empty)
                    {
                        Log.LogError("Inserting a module initializer requires the assembly to implement a class named ModuleInitializer with a static parameterless method named Initialize.");
                        return false;
                    }

                    if (Regex.Match(sourceIL, @"\.assembly extern mscorlib", RegexOptions.Singleline) == Match.Empty)
                    {
                        outputIL.WriteLine(msCorLibAssemblySectionIL);
                    }

                    if (Regex.Match(sourceIL, @"\.class private auto ansi '\<Module\>'.+?\.method private hidebysig specialname rtspecialname static void \.cctor \(\) cil managed ", RegexOptions.Singleline) == Match.Empty)
                    {
                        outputIL.WriteLine(moduleConstructorIL);
                    }
                    else
                    {
                        Log.LogError("Cannot insert a module initializer into an assembly that already contains one.");
                        return false;
                    }

                    outputIL.WriteLine(sourceIL);
                }

                return true;
            }
            catch (Exception e)
            {
                Log.LogError(e.ToString() + Environment.NewLine + e.StackTrace);
                return false;
            }
        }
    }
}
