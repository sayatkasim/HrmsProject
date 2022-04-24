// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



//JobListNameTest();
//CandidateNameTest();



static void JobListNameTest()
{
    JobListManager jobListManager = new JobListManager(new EfJobListDal());

    var result = jobListManager.GetAll();

    if (result.Success==true)
    {
        foreach (var jobList in result.Data)
        {
            Console.WriteLine(jobList.JobListName);
        }

    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void CandidateNameTest()
{
    

}