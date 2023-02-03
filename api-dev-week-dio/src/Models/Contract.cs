using System.ComponentModel.DataAnnotations;

namespace src.Models;

    public class Contract
    {
        public Contract()
        {
            this.CreationDate = DateTime.Now;
            this.Value = 0;
            this.TokenId = "000000";
            this.Payment = false;
        }
        public Contract(string TokenID, double Value)
        {
            this.CreationDate = DateTime.Now;
            this.TokenId = TokenID;
            this.Value = Value;
            this.Payment = false;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        [RegularExpression(@"^[0-9]+$", 
            ErrorMessage = "Este campo deve ser preenchido somente com números")]
        public string TokenId { get; set; }

        public double Value { get; set; }
        public bool Payment { get; set; }
        public int PersonId { get; set; }

    }
