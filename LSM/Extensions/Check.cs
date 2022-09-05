using LSM.Exceptions;

namespace LSM.Extensions
{
    public static class Check
    {
        public static string NotEmpty(string value, string parameterName)
        {
            Exception ex = null;
            if (value == null)
            {
                ex = new AppException(parameterName);
            }
            else if (value.Trim().Length == 0)
            {
                ex = new AppException(GetArgumentIsEmptyMessage(parameterName), parameterName);
            }

            if (ex != null)
            {
                NotEmpty(parameterName, "parameterName");
                throw ex;
            }

            return value;
        }

        private static string GetArgumentIsEmptyMessage(string parameterName)
        {
            return "The string argument '" + parameterName + "' cannot be empty.";
        }
    }
}
