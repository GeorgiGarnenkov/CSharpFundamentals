﻿namespace SIS.HTTP.Session.Contracts
{
    public interface IHttpSession
    {
        string Id { get; }

        object GetParameter(string name);

        bool ContainsParameter(string name);

        void AddParameter(string name, object parameter);

        void ClearParameters();
    }
}