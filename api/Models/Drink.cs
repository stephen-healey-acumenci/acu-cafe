namespace FullStackAcuCafe.Models
{
    public class Drink
    {
        public const double MilkCost = 0.5;
        public const double SugarCost = 0.5;

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }
        public string Description { get; }

        public double Cost()
        {
            return 0;
        }

        public string Prepare(double cost)
        {
            string message = "We are preparing the following drink for you: " + Description;
            if (HasMilk)
                message += " with milk";
            else
                message += " without milk";

            if (HasSugar)
                message += " with sugar";
            else
                message += " without sugar.";
                    
            message += $" It will cost £{cost}";

            return message;
        }
    }

    public class Coffee : Drink
    {
        public new string Description
        {
            get { return "Coffee"; }
        }

        public new double Cost()
        {
            double cost = 1.8;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }

    public class Tea : Drink
    {
        public new string Description
        {
            get { return "Hot tea"; }
        }

        public new double Cost()
        {
            double cost = 1;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }

    public class IceTea : Drink
    {
        public new string Description
        {
            get { return "Ice tea"; }
        }

        public new double Cost()
        {
            double cost = 1.5;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}