using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_4_FileParser.Data
{
    static class Parser
    {
        public static InputData Parse(string[] args)
        {
            if (args == null)
            {
                throw new NullReferenceException("Array of parameters is null"); //81
            }
            if (args.Length < InputData.MinCountParams ||
                args.Length > InputData.MaxCountParams)
            {
                throw new ArgumentException(
                    "The number of parameters is incorrect. " +
                    "There must be: " + InputData.MinCountParams + " " +
                    "or " + InputData.MaxCountParams);
            }

            return new InputData
            {
                PathToFile = args[0],
                TargetStr = args[1],
                ReplaceStr = args.Length > InputData.MinCountParams ?
                    args[2] : null,
                Mode = args.Length == InputData.MaxCountParams ? 
                    InputData.ProgramMode.ReplaceStr :
                    InputData.ProgramMode.SearchStr
            };
        }
    }
}
