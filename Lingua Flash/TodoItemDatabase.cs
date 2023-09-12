using SQLite;

namespace Lingua_Flash
{
    class TodoItemDatabase
    {
        SQLiteAsyncConnection Database;

        public TodoItemDatabase()
        {
        }

        async Task init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<ToDoItem>();
        }

        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            await init();
            return await Database.Table<ToDoItem>().ToListAsync();
        }

        public async Task<List<ToDoItem>> GetItemsNotDoneAsync()
        {
            await init();
            return await Database.Table<TodoItem>().Where(t => t.Done).ToListAsync();
        }

        public async Task<TodoItem> GetItemAsync(int id)
        {
            await init();
            return await Database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(TodoItem item)
        {
            await init();
            if (item.ID != 0)
                return await Database.UpdateAsync(item);
            else
                return await Database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(TodoItem item)
        {
            await init();
            return await Database.DeleteAsync(item);
        }
    }
}
