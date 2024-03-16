namespace Task1
{
     struct LinEquation
    {
        double k;
        double b;

        public LinEquation (double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {

            if (k==0 && b!=0)
            {
                return $"решений нет";
            }
            else if (k == 0 && b == 0)
            {
                return $"решений бесконечно много, x -- любое число";
            }
            else
            return $"x={(double)(-b / k)}";
        }
    }
}