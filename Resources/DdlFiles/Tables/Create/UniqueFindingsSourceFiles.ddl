CREATE TABLE IF NOT EXISTS UniqueFindingsSourceFiles (
    FindingSourceFile_ID INTEGER PRIMARY KEY,
    FindingSourceFileName NVARCHAR (500) NOT NULL UNIQUE ON CONFLICT IGNORE
);