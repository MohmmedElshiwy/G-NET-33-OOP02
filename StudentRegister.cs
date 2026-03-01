public class StudentRegister
{
    
    private List<Student> students = new List<Student>();

    public Student this [int index]
    {
        get
        {
            if(index>=0&& index<students.Count)
            return students[index];
            return null;

        }
        set
        {
            if(index>=0&& index<students.Count)
            students[index] = value;
        }
    }


    public Student this [ string name]
    {
        get
        {
            foreach(var s in students)
            {
                if(s.Name == name)
                {
                    return s;                 
                }
            }
                return null;
            
        }
        set
        {
            for(int i=0;i<students.Count;i++)
            {
                if(students[i].Name == name)
                {
                    students[i] = value;
                    break;
                }
            }
        }
    }
    
    public void AddStudent(Student st)
    {
        students.Add(st);
    }
    
}