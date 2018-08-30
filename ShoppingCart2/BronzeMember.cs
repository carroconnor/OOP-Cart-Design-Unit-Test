namespace ShoppingCart2
{
    public class BronzeMember : Member
    {
        public BronzeMember(int MemberID, string MemberName)
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        public double IsBronze(double price)
        {
            price = price * 1;
            return price;
        }
    }
}
