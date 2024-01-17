﻿using Library_WebServer.Models.Author.Request;

namespace Library_WebServer.Models.Author.Domain;

public class Author : AuthorBase
{
    public Guid Id { get; set; }

    private Author(
        string id,
        string firstName,
        string lastName) : base(firstName, lastName)
    {
        Id = Guid.Parse(id);
    }

    public Author(AuthorRequestUpdateModel model)
        : this(model.Id, model.FirstName, model.LastName) { }
}