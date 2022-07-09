namespace RMSFoundation.Enumerations
{
    public enum DbOperation{
        Undefined = 0,
        Create = 1,
        Retrieve = 2,
        Update = 3,
        Delete = 4,
    }
    public enum ValueDataType
    {
        Undefined = 0,
        Int = 1,    
        String = 2,
        Boolean = 3,
        IntArray = 4,
        StringArray = 5,
        BooleanArray = 6,
    }
    public enum UserPrivilege
    {
        Undefined = 0,
        Administrator = 100,
        BranchManager = 1,
        Manager = 2,
        OperationsManager = 3,
        Cashier = 4,
    }
    public  enum RestaurantDayPolicy
    {
        Undefined = 0,
        Default = 1,
        Strict = 2,
        Lenient = 3,
    }
    public enum RestaurantShiftPolicy 
    {
        Undefined = 0,
        Default = 1,
        Strict = 2,
        Lenient = 3
    }
    public enum ItemType
    {
        Undefined = 0,
        Item = 1,
        Deal = 2,
        AddOn = 3,
    }
    public enum OrderType
    {
        Undefined = 0,
        DineInIndoor = 1,
        DineInOutdoor = 2,
        TakeAway = 3,
        Delivery = 4,
    }
    public enum DiscountType
    {
        Undefined = 0,
        Daily = 1,
        Limited = 2,
        Unlimited = 3,
    }

    public enum PaymentMode
    {
        Undefined = 0,
        Cash = 1,
        Card = 2,
        Voucher = 3,
        Cheque = 4,
        Online = 5,
        Mixed = 6,
        Credit = 7,
    }
    public enum OrderStatus
    {
        Undefined = 0,
        Paid = 1,
        Pending = 2,
        Deleted = 3,
        FullRefund = 4,
        PartialRefund = 5,
        OnHold = 6,
        Test = 100
    }
    public enum TableStatus
    {
        Undefined = 0,
        Reserved = 1,
        Occupied = 2,
        Unoccupied = 3,
    }
    public enum RiderStatus
    {
        Undefined = 0,
        Assigned = 1,
        Unassigned = 2,
    }
    public enum CustomerSearchType
    {
        Contact = 1,
        Name = 2,
    }
    public enum Units
    {
        Undefined = 0,
        Percentage = 1,
        Amount = 2,
    }
}
