using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum IncentiveAwardType
    {
        [Display(Name = "Coins Based")]
        CoinsBased = 0,
        [Display(Name = "Rank Based")]
        RankBased = 1
    }
}
