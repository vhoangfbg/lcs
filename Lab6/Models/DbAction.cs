namespace Lab6.Models
{
    public interface DbAction
    {
        void insert();
        void update();
        void delete();
        void select();
    }
}