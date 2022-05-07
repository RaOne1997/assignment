using ConsoleApp1.Module;

interface IStudentService {
    public void Add(Stud s);
    public void Edit(Stud s);
    public void Delete(int studentId);
    public void DisplayStudentReport();

}