namespace ShoppingCart2
{
    public class SilverMember : Member
    {
        double price;

        public SilverMember(int MemberId, string MemberName)
        {
            this.MemberID = MemberId;
            this.MemberName = MemberName;
        }

        SilverMember caroline = new SilverMember(03, "Caroline OConnor");
        SilverMember kevin = new SilverMember(04, "Kevin OConnor");

        public double IsSilver()
        {
            var discount = price * .1;
            var newprice = price - discount;
            return newprice;
        }
    }
}
