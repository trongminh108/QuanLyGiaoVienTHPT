CREATE TABLE [dbo].[TaiKhoan] (
    [TenTaiKhoan] CHAR (20)    NOT NULL,
    [MatKhau]     CHAR (20)    NOT NULL,
    [email]       VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([TenTaiKhoan] ASC)
);

