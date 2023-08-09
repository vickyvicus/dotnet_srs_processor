using System;
using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum PayoutType
    {
        FOC = 1,
        Article = 2,
        Discount = 3,
        Product = 4,
        TopUpDiscount = 5,
        PerUnitDiscount = 6,
        Basket = 7,
        FixedValueDiscount = 8
    }

    public enum PayoutCalculationType
    {
        None = 0,
        Step = 1,
        Continuous = 2
    }
    public enum DiscountBlock
    {
        Primary_Category = 1,     //1.	PC or combination of PCs 
        Secondary_Category = 2,   //2.	SC or combination of SCs with in any one PC.
        Product = 3,              //3.	Product/SKU or combination of Products /SKU with in any one SC.
        All = 4
    }
    public enum QualifierPayoutType
    {
        [Display(Name = "Quantity (Unit)")]
        Quantity = 0,
        [Display(Name = "Standard Unit")]
        Standard_Unit = 1
    }

    [Obsolete]
    public enum DiscountType
    {
        Unknown = 0,
        Cash_Discount = 1,       // Can Avail bill Amount reduction equal to the Cash Discount
        FOC = 2,                 //Allows to use the Discount Amount only for Purchase in smae Block
        Article = 3,
        Open_FOC = 4,
        Other_Discount = 100
    }

    public enum ConstraintType
    {
        None = 0,
        Amount = 1,
        [Display(Name = "Quantity (Unit)")]
        Quantity = 2,
        [Display(Name = "Standard Unit")]
        Standard_Unit = 3,
        [Display(Name = "Super Unit")]
        Super_Unit = 4
    }

    public enum SchemeCategorization
    {
        Uncategorized = 0,
        Primary = 1,
        Secondary = 2
    }
    public enum SchemeType
    {
        Primary = 1,
        Secondary = 2
    }
    public enum SchemeSubType
    {
        Extendable = 1,
        NonExtendable = 2,
        Claimable = 3,
        NonClaimable = 4
    }
}
