using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum ImageContainers
    {
        [Display(Name = "outletimages")]
        OutletImages,
        [Display(Name = "surveyimages")]
        SurveyImages,
        [Display(Name = "paymentimages")]
        PaymentImages,
        [Display(Name = "invoiceimages")]
        InvoiceImages,
    }
}
