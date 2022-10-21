namespace APIT5MD2
{
    public static class Util
    {
        public static bool FirstCharUppercase(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char .IsUpper(ch);

        }
    }
}
