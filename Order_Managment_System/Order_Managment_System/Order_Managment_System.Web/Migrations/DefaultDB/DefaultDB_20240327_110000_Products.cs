using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327110000)]
    public class DefaultDB_20240327_110000_Products : Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                  .WithColumn("product_id").AsInt32().Identity().PrimaryKey().NotNullable()
                  .WithColumn("product_name").AsString().Unique()
                  .WithColumn("description").AsString()
                  .WithColumn("price").AsInt32()
                  .WithColumn("stock_quantity").AsInt32();

            Insert.IntoTable("Products")
                  .Row(
                      new
                      {
                          product_name = "Camiseta Deportiva Nike Dri-Fit",
                          description = "Camiseta transpirable para entrenamiento y running.",
                          price = 4000,
                          stock_quantity = 50
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Zapatillas Adidas Ultraboost 23",
                          description = "Zapatillas de running con amortiguación y respuesta.",
                          price = 12000,
                          stock_quantity = 40
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Raqueta de Tenis Wilson Blade",
                          description = "Raqueta de alto rendimiento para jugadores profesionales.",
                          price = 20000,
                          stock_quantity = 20
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Traje de Baño Speedo Fastskin",
                          description = "Traje de baño de competición para natación.",
                          price = 8000,
                          stock_quantity = 30
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Balón de Fútbol Puma Adrenalina",
                          description = "Balón de fútbol de alta calidad para uso profesional.",
                          price = 3500,
                          stock_quantity = 45
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Bicicleta de Montaña Trek X-Caliber",
                          description = "Bicicleta de montaña resistente para principiantes e intermedios.",
                          price = 25000,
                          stock_quantity = 15
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Mancuernas Ajustables ProForm",
                          description = "Juego de mancuernas ajustables para entrenamiento de fuerza en casa.",
                          price = 18000,
                          stock_quantity = 25
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Esterilla de Yoga Reebok",
                          description = "Esterilla de yoga antideslizante y cómoda para diferentes prácticas.",
                          price = 3500,
                          stock_quantity = 50
                      }
                  )
                  .Row(
                      new
                      {
                          product_name = "Smartwatch Deportivo Garmin Forerunner 255",
                          description = "Smartwatch con GPS para monitorizar tu actividad y rendimiento.",
                          price = 20000,
                          stock_quantity = 20
                      }
                  );
        }

        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}