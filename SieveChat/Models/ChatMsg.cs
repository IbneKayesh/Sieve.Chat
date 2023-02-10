using System;
using System.ComponentModel.DataAnnotations;

namespace SieveChat.Models
{
    public class ChatMsg
    {
        [Key]
        [StringLength(50,ErrorMessage ="length is 50 char")]
        public string MSG_ID { get; set; }

        
        public int FROM_USR { get; set; }


        public int TO_USR { get; set; }

        [StringLength(500, ErrorMessage = "length is 10 char")]
        public string MSG_TEXT { get; set; }

        [StringLength(10, ErrorMessage = "length is 10 char")]
        public string MSG_STATUS { get; set; }

        public DateTime CREATE_DATE { get; set; } = DateTime.Now;
        public DateTime UPDATE_DATE { get; set; } = DateTime.Now;
        public Nullable<DateTime> SEEN_DATE { get; set; }
        public bool IS_ACTIVE { get; set; } = true;

    }
}