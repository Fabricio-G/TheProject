using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederParametro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor"},
            values: new object[] {1, "General", "AppTitle", "Nombre de la app", "Sistema Ventas"});

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 2, "Mail", "TiempoExpiracionTokenMail", "Tiempo en minutos de expiración del token del email.", 60 });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 3, "Path", "UrlFrontend", "Url del directorio donde se encuentran las imagenes.", "definir" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 4, "General", "BaseUrlBackend", "Url backend", "http://localhost:51249/" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 5, "Mails", "Servidor", "Servidor de donde saldrán los mails", "smtp.gmail.com" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 6, "Mails", "Puerto", "Indica el puerto del servidor de correo", 25 });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 7, "Mails", "Usuario", "Indica el usuario de la cuenta", "emailparatest.system@gmail.com" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 8, "Mails", "Contraseña", "Indica contraseña de la cuenta", "123456789+a" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 9, "Mails", "RemitenteNombre", "Indica el from(quien envía el mail)", "test@test.com" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 10, "Path", "PathMailing", "Indica la ruta de la plantilla .html del mail", null });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 11, "Mails", "MetodoEnvio", "Forma de envio", "Mailgun" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] {12, "Mails", "Remitente", "Indica el remitente ", "test@test.com" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 13, "Mail", "EnableSsl", "Indica si se va a usar enable ", 1 });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 14, "Mail", "MailSoporte", "Mail soporte de System ", "system@system.com" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 15, "Key", "MailGunApiKey", "Key para la api de mailgun ", "a2286cabbc9925fb744a1e8ddfe44a00-52cbfb43-be443208" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 16, "Dominio", "MailGunDominio", "Dominio para la api de mailgun ", "sandbox0b005a61b6fa4f85a2e803de056b6886.mailgun.org" });

            migrationBuilder.InsertData(
            table: "Parametro",
            columns: new[] { "ParametroId", "Categoria", "Clave", "Descripcion", "Valor" },
            values: new object[] { 17, "Path", "UrlApiMailgun", "Url api de mailgun ", "https://api.mailgun.net/v3" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
