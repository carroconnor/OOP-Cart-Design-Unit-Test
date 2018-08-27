namespace ShoppingCart2
{
    public class GoldMember : Member
    {
        double price;

        public GoldMember(int MemberID, string MemberName)
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        GoldMember carr = new GoldMember(01, "Carr OConnor");

        public double IsGold()
        {
            var discount = price * .15;
            var newprice = price - discount;
            return newprice;
        }
    }
}
