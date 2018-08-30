namespace ShoppingCart2
{
    public class GoldMember : Member
    {
        public GoldMember(int MemberID, string MemberName)
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        public double IsGold(double price)
        {
            var discount = price * .15;
            var newprice = price - discount;
            return newprice;
        }
    }
}
