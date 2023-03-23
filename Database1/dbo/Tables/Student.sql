CREATE TABLE [dbo].[Student] (
    [studentid]     INT          IDENTITY (1, 1) NOT NULL,
    [StudentName]   VARCHAR (50) NULL,
    [StudentRollNo] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([studentid] ASC)
);

