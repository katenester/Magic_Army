/*1) Создать армии(рандомно) (ограничение по стоимости)
2) Сделать ход (бьётся только первый с первым – стек)
3) Доиграть партию до конца*/

interface IUser
{
    void Army CreateArmy(int cost);
    void DoMove();
    void Start();
}
class User: IUser
{
    void Army CreateArmy(int cost)
    {
        Army stack = new();
        var flag = true;
        // Логику создания стека юнитов желательно обернуть в графический интефрейс
        while (flag)
        {

        }
    }
    void DoMove();
    void Start();
}