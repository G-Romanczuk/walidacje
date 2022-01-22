 [Required(ErrorMessage = "Proszę podać imię Adresata!")]
        [StringLength(20, ErrorMessage = "Proszę podać poprawne imię Adresata!")]
        public string NameSender { get; set; }
        [Required(ErrorMessage = "Proszę podać Nazwisko Adresata!")]
        [StringLength(30, ErrorMessage = "Proszę podać poprawne nazwisko Adresata!")]
        public string LastNameSender { get; set; }
        [Required(ErrorMessage = "Proszę podać  numer telefonu Adresata!")]
        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu Adresata!")]
        public string TelSender { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę miasta Adresata!")]
        [MinLength(length: 2, ErrorMessage = "Proszę podać poprawną nazwę miasta Adresata!")]
        public string CityAdressSender { get; set; }
        [Required(ErrorMessage = "Proszę podać poprawną nazwę ulicy Adresata!")]
        [MaxLength(length: 50, ErrorMessage = "Proszę podać poprawną nazwę ulicy Adresata!")]
        public string StreetAdressSender { get; set; }
        [Required(ErrorMessage = "Proszę podać numer budynku Adresata!")]
        [Range(1, 3000, ErrorMessage = "Proszę podać poprawny numer budynku Adresata!")]
        public string BuildingAdressSender { get; set; }
        [Range(1,300, ErrorMessage = "Proszę podać poprawny numer mieszkania Adresata!")]
        public string ApartmentAdressSender { get; set; }
        [Required(ErrorMessage = "Proszę podać kod pocztowy Adresata!")]
        [RegularExpression("[0-9]{2}-[0-9]{3}", ErrorMessage = "Proszę podać poprawny kod pocztowy Adresata!")]
        public string KodSender { get; set; }
