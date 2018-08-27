namespace ShoppingCart2
{
    public class BronzeMember : Member
    {
        double price;

        public BronzeMember(int MemberID, string MemberName)
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        BronzeMember cali = new BronzeMember(01, "Cali OConnor");

        public double IsBronze()
        {
            price = price * 1;
            return price;
        }
    }
}
