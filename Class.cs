namespace Domain;

//Класс паспорт громадянина заданої країни - Україна

public class Passport
{
    public string Series { get; set; }
    public string Number { get; set; }
    public string IssuedBy { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }
    public string PersonalNumber { get; set; }
}
 