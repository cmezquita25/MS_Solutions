﻿using MathSolutionsBlazor.Data;

namespace MathSolutionsBlazor.Auth
{
    public interface ILocalStorage
    {
        Task<T> GetValue<T>(ValuesKeys key);

        Task SetValue<T>(ValuesKeys key, T value);

        Task RemoveItem(ValuesKeys key);

        Task ClearAll();
    }
}
