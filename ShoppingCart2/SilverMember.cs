namespace ShoppingCart2
{
    public class SilverMember : Member
    {
        public SilverMember(int MemberId, string MemberName)
        {
            this.MemberID = MemberId;
            this.MemberName = MemberName;
        }

        public double IsSilver(double price)
        {
            var discount = price * .1;
            var newprice = price - discount;
            return newprice;
        }
    }
}
