CREATE TABLE [dbo].[Studentmarks] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [SubjectId]   INT NULL,
    [StudentId]   INT NULL,
    [StudentMark] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([studentid]),
    FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subject] ([SubjectId])
);

