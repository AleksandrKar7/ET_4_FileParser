using System.IO;


namespace ET_4_FileParser.Data
{
    static class Validator
    {
        public static bool IsValid(string[] args)
        {
            if (args == null)
            {
                return false;
            }
            if (args.Length < InputData.MinCountParams ||
                args.Length > InputData.MaxCountParams)
            {
                return false;
            }

            for (int i = 0; i < InputData.MinCountParams; i++)
            {
                if(args[i] == null)
                {
                    return false;
                }
            }

            if(!File.Exists(args[0]))
            {
                return false;
            }

            return true;
        }
    }
}
