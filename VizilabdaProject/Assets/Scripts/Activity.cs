using SQLite4Unity3d;

public class Activity{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string PlayerName { get; set; }
    public string Player2Name { get; set; }
    public string ActivityName { get; set; }
    public string GoalType { get; set; }
    public string Other { get; set; }


    public override string ToString()
    {
        return string.Format("[Person: Id={0}, PlayerName={1},  ActivityName={2}, Other={3}]", Id, PlayerName, ActivityName, Other);
    }
}
