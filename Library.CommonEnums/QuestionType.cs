using System.Runtime.Serialization;

namespace Libraries.CommonEnums
{
    public enum SurveyQuestionType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "multiline")]
        Multiline,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "rating")]
        Rating,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "signature")]
        Signature,
        [EnumMember(Value = "dropdown")]
        Dropdown,
        [EnumMember(Value = "radio")]
        Radio,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "hidden")]
        Hiden,
        //Changing upload to file sprint23 TeamMT
        [EnumMember(Value = "file")]
        uploadFile
    }

    public enum SurveyDisplayWidth
    {
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "small")]
        Small
    }
}
