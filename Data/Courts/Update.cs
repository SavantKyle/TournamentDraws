using DataProvider.Contracts;
using Models;

namespace Data.Courts
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Court _court;

        public Update(int id, Court court)
        {
            _id = id;
            _court = court;
        }

        public void Execute(ISession session)
        {
            session.Execute(
                @"Update Courts 
                set Name = @Name
                where Id = @Id",
                new { _court.Name, Id = _id });
        }
    }
}
