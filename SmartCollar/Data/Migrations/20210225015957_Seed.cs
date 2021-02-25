using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartCollar.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Collar",
                columns: new[] { "DeviceId", "LastTimeSeen", "Latitude", "LocationPrecision", "Longitude" },
                values: new object[,]
                {
                    { "0", new DateTime(2021, 2, 23, 14, 59, 57, 134, DateTimeKind.Local).AddTicks(7840), -3.74113605628402m, 10m, -38.5717779070282m },
                    { "1", new DateTime(2021, 2, 23, 14, 59, 57, 136, DateTimeKind.Local).AddTicks(4471), -3.74758732640212m, 10m, -38.5730825044043m },
                    { "2", new DateTime(2021, 2, 23, 6, 59, 57, 136, DateTimeKind.Local).AddTicks(4555), -3.74475982646959m, 10m, -38.5774507982249m },
                    { "3", new DateTime(2021, 2, 24, 0, 59, 57, 136, DateTimeKind.Local).AddTicks(4562), -3.74569101662221m, 10m, -38.5784863627737m },
                    { "4", new DateTime(2021, 2, 23, 3, 59, 57, 136, DateTimeKind.Local).AddTicks(4634), -3.7409415713241m, 10m, -38.5712509937264m }
                });

            migrationBuilder.InsertData(
                table: "MobileUser",
                columns: new[] { "Id", "Hash", "Name", "Token", "UserName" },
                values: new object[,]
                {
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), "1234", "Alan", "", "Alan" },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), "1234", "Eduardo", "", "Eduardo" },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), "1234", "Lucas", "", "Lucas" },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), "1234", "João", "", "João" },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), "1234", "Carlos", "", "Carlos" },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), "1234", "José", "", "José" },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), "1234", "Maria", "", "Maria" },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), "1234", "Luana", "", "Luana" },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), "1234", "Joana", "", "Joana" },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), "1234", "Francisca", "", "Francisca" }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "NotificationId", "CreatedAt", "DeviceId", "Latitude", "LocationPrecision", "Longitude", "Time", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 14, 59, 57, 137, DateTimeKind.Local).AddTicks(8668), "0", -3.74232897270021m, 10m, -38.5782635159764m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(1041), new DateTime(2021, 2, 24, 16, 59, 57, 137, DateTimeKind.Local).AddTicks(9134) },
                    { new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2942), "3", -3.74551334212232m, 10m, -38.573836117065m, new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2946), new DateTime(2021, 2, 24, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2944) },
                    { new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2933), "3", -3.74691176719308m, 10m, -38.5733148889944m, new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2937), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2934) },
                    { new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2923), "3", -3.74117466027065m, 10m, -38.5711445803862m, new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2927), new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2925) },
                    { new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2914), "3", -3.74523565388622m, 10m, -38.5756467569883m, new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2918), new DateTime(2021, 2, 24, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2916) },
                    { new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2905), "3", -3.74605239129255m, 10m, -38.5702110065628m, new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2909), new DateTime(2021, 2, 23, 9, 59, 57, 138, DateTimeKind.Local).AddTicks(2907) },
                    { new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2896), "3", -3.74307855110899m, 10m, -38.5744974238493m, new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2900), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2898) },
                    { new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2884), "3", -3.74842292281819m, 10m, -38.5761874826901m, new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2888), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2885) },
                    { new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 24, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2875), "3", -3.74517576407742m, 10m, -38.5748429083088m, new DateTime(2021, 2, 24, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2879), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2877) },
                    { new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2863), "3", -3.74618276804974m, 10m, -38.5780257833339m, new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2867), new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2864) },
                    { new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2853), "3", -3.74069747604183m, 10m, -38.5785608810864m, new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2857), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2855) },
                    { new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2844), "3", -3.74484586548612m, 10m, -38.5727917719194m, new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2848), new DateTime(2021, 2, 23, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2846) },
                    { new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2834), "3", -3.74668727128985m, 10m, -38.5779846992176m, new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2838), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2836) },
                    { new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2825), "3", -3.74600259128772m, 10m, -38.5781746742484m, new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2829), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2827) },
                    { new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2815), "2", -3.7443536660333m, 10m, -38.5751810323676m, new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2819), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2817) },
                    { new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2802), "2", -3.74766142443785m, 10m, -38.5736099569726m, new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2806), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2804) },
                    { new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2793), "2", -3.74794489390726m, 10m, -38.5778812962379m, new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2797), new DateTime(2021, 2, 24, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(2795) },
                    { new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 24, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2784), "2", -3.74852325759806m, 10m, -38.5707262873755m, new DateTime(2021, 2, 24, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2788), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2786) },
                    { new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2775), "2", -3.74033252015725m, 10m, -38.5723358648794m, new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2779), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2777) },
                    { new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2765), "2", -3.7434947857589m, 10m, -38.5746656747096m, new DateTime(2021, 2, 24, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2769), new DateTime(2021, 2, 24, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(2767) },
                    { new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2756), "2", -3.74148338629607m, 10m, -38.576434489988m, new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2760), new DateTime(2021, 2, 24, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2758) },
                    { new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2747), "2", -3.74323871688602m, 10m, -38.576572780012m, new DateTime(2021, 2, 23, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2751), new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2748) },
                    { new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 22, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2951), "3", -3.74886060006538m, 10m, -38.5739509388371m, new DateTime(2021, 2, 22, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2955), new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(2953) },
                    { new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(2737), "2", -3.74438863195544m, 10m, -38.5720264965738m, new DateTime(2021, 2, 24, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(2741), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2739) },
                    { new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2960), "3", -3.74308149058376m, 10m, -38.571742790345m, new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2964), new DateTime(2021, 2, 23, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2962) },
                    { new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2982), "3", -3.74307220643576m, 10m, -38.5726557756535m, new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2986), new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2984) },
                    { new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(3179), "4", -3.74474443230813m, 10m, -38.5770899533369m, new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(3183), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3181) },
                    { new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(3170), "4", -3.74844442741221m, 10m, -38.5739349264181m, new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(3174), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3172) },
                    { new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3161), "4", -3.74127253077937m, 10m, -38.5733744271823m, new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3166), new DateTime(2021, 2, 23, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3163) },
                    { new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(3152), "4", -3.74734958502154m, 10m, -38.5717855140203m, new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(3157), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3154) },
                    { new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3143), "4", -3.74685914612462m, 10m, -38.5721896619155m, new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3147), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3145) },
                    { new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 23, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3134), "4", -3.74502090251121m, 10m, -38.57299122182m, new DateTime(2021, 2, 23, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(3136) },
                    { new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3125), "4", -3.74786241361632m, 10m, -38.5787913043866m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3129), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3127) },
                    { new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 22, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(3112), "4", -3.74420262232758m, 10m, -38.5746811244514m, new DateTime(2021, 2, 22, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(3116), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3114) },
                    { new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3103), "4", -3.74031811058024m, 10m, -38.5723851669572m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3107), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3105) },
                    { new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3094), "4", -3.74429713688991m, 10m, -38.5774389050712m, new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3096) },
                    { new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3085), "4", -3.74146325452787m, 10m, -38.5751009055516m, new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3089), new DateTime(2021, 2, 23, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(3086) },
                    { new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3076), "4", -3.74055194913715m, 10m, -38.5720283206059m, new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3080), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(3078) },
                    { new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 23, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(3067), "4", -3.7455323120875m, 10m, -38.5747740563428m, new DateTime(2021, 2, 23, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(3071), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(3069) },
                    { new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3058), "4", -3.74851697938494m, 10m, -38.5739479949116m, new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(3060) },
                    { new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3048), "4", -3.74209981809328m, 10m, -38.5743172640397m, new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3053), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(3050) },
                    { new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(3036), "4", -3.74007891731992m, 10m, -38.5700576386308m, new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(3040), new DateTime(2021, 2, 24, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(3038) },
                    { new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3027), "4", -3.74193309218201m, 10m, -38.5733916827843m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(3031), new DateTime(2021, 2, 24, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(3029) },
                    { new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(3018), "4", -3.74092695686823m, 10m, -38.5781065688963m, new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(3022), new DateTime(2021, 2, 24, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(3020) },
                    { new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3009), "3", -3.7405464717604m, 10m, -38.5789400616768m, new DateTime(2021, 2, 24, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(3013), new DateTime(2021, 2, 24, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(3011) },
                    { new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2999), "3", -3.74320873069447m, 10m, -38.5747818739218m, new DateTime(2021, 2, 23, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(3003), new DateTime(2021, 2, 24, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(3001) },
                    { new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2990), "3", -3.74734355947671m, 10m, -38.5759387689414m, new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2995), new DateTime(2021, 2, 23, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(2992) },
                    { new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2972), "3", -3.74077758696991m, 10m, -38.5716781977814m, new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2977), new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2974) },
                    { new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2724), "2", -3.74185568669339m, 10m, -38.5757993867513m, new DateTime(2021, 2, 23, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2729), new DateTime(2021, 2, 24, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(2726) },
                    { new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2716), "2", -3.74850064290897m, 10m, -38.5762163359249m, new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2720), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2718) },
                    { new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2707), "2", -3.74214064209822m, 10m, -38.5700903890524m, new DateTime(2021, 2, 24, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2711), new DateTime(2021, 2, 24, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(2709) },
                    { new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2388), "1", -3.74152997339588m, 10m, -38.5757482365266m, new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2392), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2390) },
                    { new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2379), "1", -3.74390547305155m, 10m, -38.5730934689185m, new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2383), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2381) },
                    { new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2367), "0", -3.74054060724449m, 10m, -38.5778370176064m, new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2371), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2369) },
                    { new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2352), "0", -3.74400557358237m, 10m, -38.57362057329m, new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2357), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2354) },
                    { new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 23, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2343), "0", -3.74459390466362m, 10m, -38.5758706330414m, new DateTime(2021, 2, 23, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2347), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2345) },
                    { new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2332), "0", -3.74007767039867m, 10m, -38.5718064042711m, new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2336), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2333) },
                    { new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2323), "0", -3.74041226137216m, 10m, -38.5729531104965m, new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2327), new DateTime(2021, 2, 24, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2325) },
                    { new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2313), "0", -3.74843506617166m, 10m, -38.5707331173149m, new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2318), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2315) },
                    { new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 23, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2304), "0", -3.74244001147637m, 10m, -38.577353655324m, new DateTime(2021, 2, 23, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2308), new DateTime(2021, 2, 24, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(2306) },
                    { new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2294), "0", -3.74025885362609m, 10m, -38.5776851067718m, new DateTime(2021, 2, 23, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2299), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2296) },
                    { new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 24, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2284), "0", -3.74184841747947m, 10m, -38.5710825658655m, new DateTime(2021, 2, 24, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2289), new DateTime(2021, 2, 24, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2286) },
                    { new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2269), "0", -3.74774911391817m, 10m, -38.5726236245463m, new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2274), new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2271) },
                    { new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 22, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2259), "0", -3.74261694675946m, 10m, -38.5775627869724m, new DateTime(2021, 2, 22, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2264), new DateTime(2021, 2, 23, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(2261) },
                    { new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2248), "0", -3.7426286318659m, 10m, -38.5783530383568m, new DateTime(2021, 2, 24, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(2252), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2250) },
                    { new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 24, 9, 59, 57, 138, DateTimeKind.Local).AddTicks(2239), "0", -3.74286264953989m, 10m, -38.5733457438696m, new DateTime(2021, 2, 24, 9, 59, 57, 138, DateTimeKind.Local).AddTicks(2243), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2241) },
                    { new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 24, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2229), "0", -3.74079884988433m, 10m, -38.5704796081285m, new DateTime(2021, 2, 24, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2233), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2230) },
                    { new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2218), "0", -3.74716131921167m, 10m, -38.5731823667424m, new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2223), new DateTime(2021, 2, 24, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2220) },
                    { new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2204), "0", -3.74667059229998m, 10m, -38.5742121990585m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2208), new DateTime(2021, 2, 24, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(2206) },
                    { new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(2194), "0", -3.7481856913926m, 10m, -38.5743209163199m, new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(2198), new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2196) },
                    { new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2173), "0", -3.74050762285875m, 10m, -38.5765958942038m, new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2178), new DateTime(2021, 2, 23, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2176) },
                    { new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2070), "0", -3.74692556569163m, 10m, -38.5766356121956m, new DateTime(2021, 2, 23, 10, 59, 57, 138, DateTimeKind.Local).AddTicks(2128), new DateTime(2021, 2, 24, 19, 59, 57, 138, DateTimeKind.Local).AddTicks(2091) },
                    { new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 24, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2398), "1", -3.74540192610184m, 10m, -38.5705804056984m, new DateTime(2021, 2, 24, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2402), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2399) },
                    { new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2407), "1", -3.74635684499487m, 10m, -38.572760667913m, new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2411), new DateTime(2021, 2, 24, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2409) },
                    { new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2416), "1", -3.74633199160422m, 10m, -38.5754798805087m, new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2421), new DateTime(2021, 2, 23, 3, 59, 57, 138, DateTimeKind.Local).AddTicks(2418) },
                    { new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2426), "1", -3.74156370583296m, 10m, -38.5757414820412m, new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2428) },
                    { new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2698), "2", -3.74054264172518m, 10m, -38.5708327558436m, new DateTime(2021, 2, 23, 23, 59, 57, 138, DateTimeKind.Local).AddTicks(2702), new DateTime(2021, 2, 24, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2699) },
                    { new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 23, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2688), "2", -3.74733434989412m, 10m, -38.571987801631m, new DateTime(2021, 2, 23, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2693), new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2690) },
                    { new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2679), "2", -3.74554648646831m, 10m, -38.5758837732966m, new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2683), new DateTime(2021, 2, 23, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(2681) },
                    { new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2669), "2", -3.74317433778857m, 10m, -38.5754422184217m, new DateTime(2021, 2, 23, 8, 59, 57, 138, DateTimeKind.Local).AddTicks(2673), new DateTime(2021, 2, 24, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2671) },
                    { new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2606), "2", -3.74023269108694m, 10m, -38.5758098973435m, new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2610), new DateTime(2021, 2, 24, 14, 59, 57, 138, DateTimeKind.Local).AddTicks(2608) },
                    { new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2593), "2", -3.74333707977288m, 10m, -38.5743764935012m, new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2597), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2595) },
                    { new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2583), "2", -3.74020771452841m, 10m, -38.5735452719776m, new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2588), new DateTime(2021, 2, 23, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2585) },
                    { new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2574), "2", -3.74095700481346m, 10m, -38.5745195080268m, new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2579), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2576) },
                    { new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2565), "1", -3.74231075510723m, 10m, -38.5735224782762m, new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2569), new DateTime(2021, 2, 23, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2567) },
                    { new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2556), "1", -3.74084797491545m, 10m, -38.5765843279276m, new DateTime(2021, 2, 23, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2560), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2558) },
                    { new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 22, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3188), "4", -3.74553264545674m, 10m, -38.5724003919006m, new DateTime(2021, 2, 22, 21, 59, 57, 138, DateTimeKind.Local).AddTicks(3193), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(3190) },
                    { new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2547), "1", -3.74022018340147m, 10m, -38.5761499327319m, new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2551), new DateTime(2021, 2, 24, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(2549) },
                    { new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2529), "1", -3.74898382283048m, 10m, -38.577168232991m, new DateTime(2021, 2, 23, 2, 59, 57, 138, DateTimeKind.Local).AddTicks(2533), new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2531) },
                    { new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 23, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2516), "1", -3.74455749167714m, 10m, -38.5747867576586m, new DateTime(2021, 2, 23, 1, 59, 57, 138, DateTimeKind.Local).AddTicks(2520), new DateTime(2021, 2, 24, 17, 59, 57, 138, DateTimeKind.Local).AddTicks(2518) },
                    { new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2507), "1", -3.74692325580675m, 10m, -38.5747659218399m, new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2511), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2508) },
                    { new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2495), "1", -3.74015184810439m, 10m, -38.5783522210626m, new DateTime(2021, 2, 24, 13, 59, 57, 138, DateTimeKind.Local).AddTicks(2500), new DateTime(2021, 2, 24, 18, 59, 57, 138, DateTimeKind.Local).AddTicks(2497) },
                    { new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2486), "1", -3.74074210502428m, 10m, -38.5725051336463m, new DateTime(2021, 2, 23, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2490), new DateTime(2021, 2, 23, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2488) },
                    { new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2477), "1", -3.74481873309371m, 10m, -38.5742438834907m, new DateTime(2021, 2, 23, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2481), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2479) },
                    { new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2468), "1", -3.74377813225322m, 10m, -38.571114090174m, new DateTime(2021, 2, 23, 22, 59, 57, 138, DateTimeKind.Local).AddTicks(2472), new DateTime(2021, 2, 24, 7, 59, 57, 138, DateTimeKind.Local).AddTicks(2470) },
                    { new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2459), "1", -3.74492518226659m, 10m, -38.5714896579587m, new DateTime(2021, 2, 23, 11, 59, 57, 138, DateTimeKind.Local).AddTicks(2463), new DateTime(2021, 2, 24, 12, 59, 57, 138, DateTimeKind.Local).AddTicks(2461) },
                    { new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2450), "1", -3.74320543083977m, 10m, -38.5774134175896m, new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2454), new DateTime(2021, 2, 24, 16, 59, 57, 138, DateTimeKind.Local).AddTicks(2452) },
                    { new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2436), "1", -3.74329614368095m, 10m, -38.5727079651462m, new DateTime(2021, 2, 24, 5, 59, 57, 138, DateTimeKind.Local).AddTicks(2440), new DateTime(2021, 2, 24, 20, 59, 57, 138, DateTimeKind.Local).AddTicks(2438) },
                    { new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2538), "1", -3.74197440698509m, 10m, -38.5745304794519m, new DateTime(2021, 2, 24, 6, 59, 57, 138, DateTimeKind.Local).AddTicks(2542), new DateTime(2021, 2, 24, 15, 59, 57, 138, DateTimeKind.Local).AddTicks(2540) },
                    { new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3201), "4", -3.74436650418368m, 10m, -38.5724710630288m, new DateTime(2021, 2, 23, 0, 59, 57, 138, DateTimeKind.Local).AddTicks(3205), new DateTime(2021, 2, 23, 4, 59, 57, 138, DateTimeKind.Local).AddTicks(3203) }
                });

            migrationBuilder.InsertData(
                table: "UserNotification",
                columns: new[] { "UserId", "NotificationId", "CreatedAt", "Text", "UpdatedAt", "WasAnAttack" },
                values: new object[,]
                {
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(322), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(332), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7126), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7127), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7601), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7603), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3115), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3116), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3638), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3639), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4193), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4195), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4666), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4668), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5143), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5145), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5660), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5662), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6140), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6142), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6635), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6637), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7130), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7132), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7605), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7607), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3119), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3120), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3642), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3644), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4198), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4199), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4671), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4672), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5147), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5149), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5664), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5666), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6145), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6146), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6640), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6641), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7135), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7137), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7610), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7612), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3123), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3125), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3647), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3648), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4202), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4204), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4675), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4676), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5152), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5153), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6631), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6633), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5669), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5670), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6136), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6137), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5139), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5140), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6618), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6619), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7113), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7114), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7588), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7589), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3054), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3055), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3625), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3626), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4180), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4182), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4653), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4655), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5130), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5132), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5647), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5649), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6127), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6128), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6622), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6624), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7117), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7119), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7592), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7594), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3058), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3059), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3629), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3631), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4185), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4186), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4658), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4659), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5135), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5136), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5651), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5653), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6131), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6133), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6627), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6628), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7121), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7123), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7597), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7598), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3110), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3111), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3634), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3635), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4189), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4191), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4662), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4663), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5656), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5658), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6149), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6150), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6644), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6646), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7140), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7141), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3665), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3666), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4220), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4222), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4692), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4694), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5169), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5171), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5687), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5688), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6166), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6168), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6662), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6664), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7157), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7158), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7632), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(7634), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3145), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3147), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3669), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3671), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4224), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4226), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4697), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4698), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5174), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5175), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5691), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5693), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6171), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6172), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6667), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6668), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7162), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7163), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("17236614-466d-480f-b238-2117af38f6f9"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7637), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7638), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3150), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3151), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3673), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3675), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4229), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4231), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4701), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4703), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5179), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5180), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5695), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5697), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6175), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6177), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6671), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6673), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3141), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3143), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7628), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7629), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7152), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7154), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6658), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6659), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7614), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7616), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3128), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3129), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3651), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3653), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4207), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4208), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4679), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4680), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5156), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5158), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5674), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5675), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6153), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6155), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6649), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6650), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7144), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7146), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7619), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7620), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3132), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3134), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3656), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3657), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6122), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6124), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4211), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4213), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5161), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5162), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5678), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5679), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6157), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6159), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6653), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6654), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7148), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7150), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7623), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7625), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3137), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3138), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3660), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3662), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4216), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4217), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4688), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4689), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5165), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5166), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5682), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5684), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6162), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6163), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4683), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4685), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7166), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7168), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5643), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5644), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4649), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4651), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4609), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4611), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5086), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5088), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5603), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5604), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6083), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6084), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6558), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6560), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7073), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7075), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7548), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7549), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3014), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3016), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3585), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3587), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4062), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4063), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4614), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4615), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5091), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5092), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5607), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5609), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6087), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6089), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6563), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6564), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7078), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7079), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7552), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7554), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3018), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3020), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3589), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3591), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4067), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4068), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4618), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4619), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5095), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5097), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5612), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5613), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6092), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6093), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6567), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6568), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7082), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7084), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7557), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7558), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4057), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4059), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3023), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3025), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3581), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3582), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7544), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7545), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4044), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4046), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4596), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4598), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5073), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5075), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5590), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5591), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6069), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6071), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6545), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6547), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7060), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(7061), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7535), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7536), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3001), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3002), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3571), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3573), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4049), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4050), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4600), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4602), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5078), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5079), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5594), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5596), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6074), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6075), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6549), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6551), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7064), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7066), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7539), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7541), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3005), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3007), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3576), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3577), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4053), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4054), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4605), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4606), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5082), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5083), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5598), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5600), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6078), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6080), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6554), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6556), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7069), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7070), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3010), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3011), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3594), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3595), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4071), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4072), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4622), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4624), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6109), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6110), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6585), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6586), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7100), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7101), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7575), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7576), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3040), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3042), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3611), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3613), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4168), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4169), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4640), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4642), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5117), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5119), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5634), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5635), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6113), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6115), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6609), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6610), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7104), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7106), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7579), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7580), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3045), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3046), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3616), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3617), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4172), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4173), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4645), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4646), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5122), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5124), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5638), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5640), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6118), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6119), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6613), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6615), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7108), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7110), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7583), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7585), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3049), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3051), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3620), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3622), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4176), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4177), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5629), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5631), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5113), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5115), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4636), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4637), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4163), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4165), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5100), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5101), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5616), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5618), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6096), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6098), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6571), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6573), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7086), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7088), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7561), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7563), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3027), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3029), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3598), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3600), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4154), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4156), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4627), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4628), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5104), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5106), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5621), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5622), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6101), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6102), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5126), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5128), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6576), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6577), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7566), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7567), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3032), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3033), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3603), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3604), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4159), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4161), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4631), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4633), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5109), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5110), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5625), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5626), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6105), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6106), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6580), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6582), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7095), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7097), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7570), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7572), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3036), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3038), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3607), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3608), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7091), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7092), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3567), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3568), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7641), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7642), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3678), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3679), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7238), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7239), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7711), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7712), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3223), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3224), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3749), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3750), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4303), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4305), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4778), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4779), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5253), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5255), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5806), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5807), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6284), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6286), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6746), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6748), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(7242), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(7243), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7715), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7717), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3227), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3229), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3753), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3754), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4308), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4309), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4782), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4784), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5257), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5259), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5810), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5812), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6289), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6290), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6751), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6752), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7246), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7248), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7720), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7721), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3232), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3233), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3757), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3759), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4312), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4314), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4786), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4788), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5262), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5263), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6742), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6743), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5815), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5817), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6280), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6281), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5249), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5250), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6729), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6730), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7224), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7225), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7698), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7699), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3210), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3211), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3735), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3737), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4290), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4292), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4764), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4766), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5240), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5241), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5757), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5759), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6271), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6272), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6733), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6734), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7228), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7230), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7702), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(7704), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3214), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3216), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3739), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3741), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4294), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4296), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4769), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4770), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5245), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5246), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5762), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5764), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6275), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6277), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6737), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6739), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7233), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7235), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7707), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7708), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3219), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3220), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3744), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3746), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4299), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4300), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4773), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4775), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5801), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5803), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6293), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6294), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6755), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6756), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7251), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7252), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3774), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3776), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4330), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4331), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4804), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4805), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5279), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5281), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5833), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5835), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6311), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6312), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6772), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6774), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7268), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7270), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7741), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7743), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3254), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3255), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3779), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3780), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4334), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4336), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4808), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4810), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5284), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5285), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5838), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5839), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6315), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6317), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6776), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6778), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7272), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7274), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7746), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7747), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3258), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3260), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3784), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3785), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4338), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4340), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4813), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4814), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5288), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5289), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5842), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5843), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6320), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6321), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6781), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6782), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3249), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3251), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(7737), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7738), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7264), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7265), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6768), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6769), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7724), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7725), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3236), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3238), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3761), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3763), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4316), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4318), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4791), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4792), true }
                });

            migrationBuilder.InsertData(
                table: "UserNotification",
                columns: new[] { "UserId", "NotificationId", "CreatedAt", "Text", "UpdatedAt", "WasAnAttack" },
                values: new object[,]
                {
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5266), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5267), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5819), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5821), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6298), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6299), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6759), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6761), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7255), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7256), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7728), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7730), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3240), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3242), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3766), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3767), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6266), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6268), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4321), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4322), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5270), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5272), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5824), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5825), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6302), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6304), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6763), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6765), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7259), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7261), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7733), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7734), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3245), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3246), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3770), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3772), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4325), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4327), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4799), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4801), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5275), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5276), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5829), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5830), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6306), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6308), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4795), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4796), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3154), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3155), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5753), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5755), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4760), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4761), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4719), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4721), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5196), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5197), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5713), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5715), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6226), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6227), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6689), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6691), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7184), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7186), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7659), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7660), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3171), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3172), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3696), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3697), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4251), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4252), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4723), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4725), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5200), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5202), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5718), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5719), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6230), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6232), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6693), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6695), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7189), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7190), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7663), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7665), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3175), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3177), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3700), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3702), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4255), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4257), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4728), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4730), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5205), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5206), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5722), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5724), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6235), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6236), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6698), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6699), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7193), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7194), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7668), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7669), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4247), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4248), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3179), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3181), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3691), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3693), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7654), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7656), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4233), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4235), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4706), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4707), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5183), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5184), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5700), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5701), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6212), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6214), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6676), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6677), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7171), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7172), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7645), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7647), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3158), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3160), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3682), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3684), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4238), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4239), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4710), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4712), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5187), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5189), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5704), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5705), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6217), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6219), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6680), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6682), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7175), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7177), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("01167724-ced8-42cd-812c-19e5ae648027"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7650), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7651), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3162), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3164), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3687), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3688), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4242), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4244), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4715), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4716), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5192), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5193), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5708), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5710), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6221), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6223), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6685), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6686), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7180), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7181), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3166), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3168), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3705), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3706), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4260), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4261), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4733), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4734), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6253), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6254), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6715), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6717), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7211), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7212), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7685), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7687), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3197), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3198), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3723), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3724), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4278), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4279), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4751), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4752), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5227), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5228), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5745), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5746), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6257), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6259), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6720), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6721), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7215), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7217), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7689), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7691), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3201), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3202), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3727), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3728), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4282), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4283), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4755), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4757), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5231), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5233), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5749), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5750), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6262), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6263), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6724), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6726), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7219), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7221), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7694), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7695), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3205), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3207), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3731), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3732), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4286), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4287), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5740), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5742), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5222), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5224), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4746), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4748), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4273), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4275), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5209), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5210), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5727), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5728), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6239), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6241), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6702), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6704), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7198), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7199), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7672), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7673), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3184), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3185), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3709), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3711), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4264), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4266), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4737), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4739), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5213), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5215), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5731), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5733), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6244), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6245), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5236), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5237), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6707), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6708), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7676), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7678), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3188), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3189), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3714), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3715), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4269), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4270), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4742), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4743), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5218), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5219), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5735), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5737), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6248), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6250), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6711), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6713), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7206), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7208), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7681), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7682), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3192), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3194), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fba34323-f788-4051-a603-e22715e94671"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3718), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3720), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7202), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7203), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2996), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2998), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7530), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(7532), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7055), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7057), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6391), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6393), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6853), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6855), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7349), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7351), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(2841), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(2842), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3382), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3384), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3892), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3893), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4413), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4415), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4890), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4892), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5439), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5441), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5919), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5921), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6396), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6397), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6858), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6859), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7354), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7355), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(2847), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(2849), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3387), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3388), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3896), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3898), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4418), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4420), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4895), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4896), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5444), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5445), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5924), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5925), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6400), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6402), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6862), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6864), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7358), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7360), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2852), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(2853), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3391), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3393), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3901), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3902), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4423), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4424), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5915), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5916), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4899), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4901), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5435), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5437), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4409), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4411), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5901), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5903), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6378), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6380), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6840), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6841), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7336), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(7337), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2827), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2829), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3370), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3371), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3879), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3880), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4400), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4402), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4877), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4878), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5426), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5427), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5906), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5907), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6382), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6384), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6845), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6846), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7341), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7342), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(2832), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(2833), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3374), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3375), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3883), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3885), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4405), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4406), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4881), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4883), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5431), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5432), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5910), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5912), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6387), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6388), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6849), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6851), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7345), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7347), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(2836), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2838), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3378), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3380), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3887), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3889), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4886), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4887), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5448), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5450), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5928), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5929), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6405), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6406), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(2870), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(2871), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3409), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3411), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3919), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3920), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4440), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4442), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4948), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4950), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5466), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5468), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5946), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5947), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6422), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6424), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6884), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6886), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7380), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7382), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(2874), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(2876), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3414), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3415), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3923), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3925), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4445), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4446), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4952), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4954), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5470), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5472), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5950), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5952), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6426), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6428), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6888), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6890), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7385), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7386), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(2879), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(2880), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3418), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3419), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3928), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3930), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4449), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4450), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4957), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4958), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5475), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5476), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5954), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5956), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7376), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7377), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6880), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6882), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6418), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6419), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5941), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5942), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6867), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6868), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7362), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7364), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2856), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(2858), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3396), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3397), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3905), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3907), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4427), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4428), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4904), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4905), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5453), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5454), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5932), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5933), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6409), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6410), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6871), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6873), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(7367), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7368), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2861), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(2862), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5378), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5379), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3401), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3402), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4431), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4433), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4908), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4909), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5457), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5458), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5936), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5938), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6413), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6415), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6876), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6877), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7371), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7373), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(2866), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(2867), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3405), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3406), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3914), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3916), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4436), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4437), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4943), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4945), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5461), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5463), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3910), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3911), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6431), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6432), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4872), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4874), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3874), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3876), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3803), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3804), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4357), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4358), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4832), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4834), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5307), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5308), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5861), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5863), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6339), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6340), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6800), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6801), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7296), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7298), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(2780), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2781), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3330), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3331), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3807), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3808), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4361), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4363), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4837), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4838), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5311), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5312), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5866), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5867), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6343), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6345), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6804), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6805), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7301), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7302), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2787), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2789), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3334), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3336), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3811), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3813), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4365), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4367), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4841), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4843), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5346), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5347), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5870), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5872), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6347), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6349), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6808), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6810), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3325), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3327), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7305), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7307), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2774), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(2776), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6795), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6797), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3311), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3312), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3790), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3791), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4344), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4345), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4819), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4820), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5294), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5295), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5848), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5849), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6326), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6327), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6786), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6788), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7283), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7284), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2702), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2711), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3316), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3317), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3794), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3796), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4348), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4350), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(4824), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4825), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5298), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5299), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5852), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5854), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6330), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6332), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6791), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6793), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7287), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7289), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(2768), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(2770), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3320), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3322), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3799), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3800), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4352), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4354), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4828), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4829), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5302), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5304), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5857), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5858), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6335), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6336), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7292), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7293), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(2792), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(2794), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3339), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3340), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3816), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3817), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5364), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5365), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5888), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5889), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6365), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6366), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6826), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6828), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7323), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7324), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(2814), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2816), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3356), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3357), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3865), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3867), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4387), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4389), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4863), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4865), false }
                });

            migrationBuilder.InsertData(
                table: "UserNotification",
                columns: new[] { "UserId", "NotificationId", "CreatedAt", "Text", "UpdatedAt", "WasAnAttack" },
                values: new object[,]
                {
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5368), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5370), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5892), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5894), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6369), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6371), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6831), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6832), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7327), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(7329), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2819), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2820), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3361), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3362), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3870), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3871), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(4392), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4393), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4868), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4869), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5373), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5374), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5897), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5898), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6374), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6375), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6835), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6837), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7332), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7333), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(2823), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2824), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3365), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3367), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4859), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4860), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4383), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4384), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3860), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(3861), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3352), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3353), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4370), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4371), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4846), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4847), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5351), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5352), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5875), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5876), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6352), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6353), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6813), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6814), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7310), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7311), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2798), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(2799), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(3343), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3345), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3820), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3821), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4374), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4375), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4850), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4851), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5355), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5357), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"), new DateTime(2021, 2, 23, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(4396), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4397), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5879), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5881), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6817), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6819), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7314), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7315), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(2803), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2804), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3347), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3349), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3825), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3826), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4378), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4380), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4854), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4856), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5359), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5361), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5883), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5885), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6360), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6362), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6822), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6823), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7318), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7320), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(2809), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2811), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6356), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6358), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6893), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6895), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7389), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7390), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(2883), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(2885), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6964), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6965), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7491), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7492), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(2955), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2957), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3527), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3529), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4004), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4006), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4556), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4557), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5033), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5034), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5550), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5552), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6030), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6031), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6506), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6507), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6968), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6970), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7495), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7497), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2960), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2961), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3531), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3533), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4009), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4011), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4560), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4562), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5037), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5039), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5554), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5556), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6034), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6036), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6510), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6511), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6973), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6974), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7500), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7501), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(2964), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(2966), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3536), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3537), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4013), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4015), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4565), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4566), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 24, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5042), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5043), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6501), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6503), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5559), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5560), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6025), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6027), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5028), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(5030), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6488), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6489), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6950), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6952), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7478), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(7479), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2942), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(2944), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3514), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3515), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3990), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3992), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4542), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4544), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5019), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5021), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5537), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5539), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6016), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6018), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6492), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6494), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6955), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6956), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7482), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7484), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(2946), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2948), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3518), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3519), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3995), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3997), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(4547), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4548), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5024), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5025), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5542), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5543), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6021), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6023), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6496), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6498), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6959), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6961), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7487), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7488), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2951), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(2952), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3523), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3524), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4000), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4001), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4551), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4553), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5546), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5547), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6039), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6040), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6514), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6516), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6977), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6979), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3554), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3555), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4031), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4032), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4583), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4584), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5060), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5062), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5576), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5578), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6056), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6058), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6532), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6533), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7046), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7048), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7522), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7523), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2987), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2989), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3558), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3560), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4035), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4037), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4587), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4588), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5065), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5066), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5581), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5582), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6061), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6062), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6536), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6538), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7051), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7052), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7526), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(7528), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2992), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(2993), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3563), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3564), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4040), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4041), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4591), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4593), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5069), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5071), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(5585), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5587), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6065), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6066), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("62022881-ad46-42c7-b730-31482d928876"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6541), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6542), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(2983), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2984), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7517), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7519), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7042), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7043), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6528), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6529), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7504), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(7506), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(2969), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2970), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3540), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3542), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4018), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4019), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4569), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4571), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5046), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5048), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5563), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5565), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6043), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6044), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6519), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6520), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(7032), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7034), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7509), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(7510), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 24, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(2973), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(2975), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3545), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3546), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6012), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6014), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(4022), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4024), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5051), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5052), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5568), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5569), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(6047), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6049), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6523), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6525), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7038), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7039), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7513), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7515), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(2978), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(2979), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(3549), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3551), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4027), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4028), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4578), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4580), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(5056), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5057), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5572), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5573), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6052), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6053), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4574), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(4575), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5532), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5534), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5015), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5016), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4538), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4539), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(4467), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4468), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(4975), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(4976), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5493), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(5494), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5972), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5973), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6448), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6449), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6911), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6912), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7406), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7408), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2900), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(2902), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(3473), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3475), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3950), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3952), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4471), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4472), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4979), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4981), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5497), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5499), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5976), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5978), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6452), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(6454), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6915), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6916), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7442), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7444), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(2905), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(2906), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3478), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3480), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3955), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3956), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4475), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4477), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4984), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4985), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5502), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5503), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5981), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5982), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(6457), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6458), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(6919), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6921), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7447), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(7449), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3946), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3947), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3435), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(3437), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(2896), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(2898), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7402), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7403), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3422), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(3424), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3932), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3934), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4453), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4455), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(4961), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(4963), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5479), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(5481), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5959), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(5960), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6435), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6436), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6898), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6899), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64"), new DateTime(2021, 2, 24, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(7393), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7395), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 23, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(2888), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2889), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 23, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3427), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3428), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(3937), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3938), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4458), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(4459), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(2909), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2910), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4966), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4967), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5963), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5964), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6439), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6441), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(6902), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6903), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(7398), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7399), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 22, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(2892), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(2893), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3431), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3433), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(3942), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3943), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4462), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4464), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4970), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(4972), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5488), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(5490), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(5967), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(5969), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6444), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6445), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6906), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(6908), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5484), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5485), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(7277), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(7278), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(3483), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3484), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 24, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(4480), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4481), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5999), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6000), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6474), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(6476), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 22, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(6937), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(6939), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(7465), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(7466), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(2929), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(2930), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(3501), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3502), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(3977), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3979), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(4497), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4499), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5006), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 10, 59, 57, 139, DateTimeKind.Local).AddTicks(5007), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 23, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5524), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5525), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 23, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6003), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(6005), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6479), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6480), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6942), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(6943), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"), new DateTime(2021, 2, 24, 20, 59, 57, 139, DateTimeKind.Local).AddTicks(7469), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7471), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2933), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(2935), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 22, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3505), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(3507), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 24, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(3982), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3983), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4533), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4534), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5010), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(5012), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 15, 59, 57, 139, DateTimeKind.Local).AddTicks(5528), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(5530), true },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6008), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6009), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6483), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(6485), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 23, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(6946), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(6948), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(7474), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(7475), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(2938), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(2939), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(3509), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 26, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(3511), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3986), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3988), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(5519), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5521), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5002), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5003), true },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 23, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4493), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(4494), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3973), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 26, 6, 59, 57, 139, DateTimeKind.Local).AddTicks(3974), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4988), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(4990), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(5506), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(5508), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(5985), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(5987), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6461), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(6463), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(6924), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 26, 12, 59, 57, 139, DateTimeKind.Local).AddTicks(6925), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(7452), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(7453), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(2913), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(2914), true },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3488), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3489), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(3964), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3965), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4484), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(4486), true },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(4993), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(4994), false },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 24, 17, 59, 57, 139, DateTimeKind.Local).AddTicks(5510), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 2, 59, 57, 139, DateTimeKind.Local).AddTicks(5512), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 24, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5990), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 9, 59, 57, 139, DateTimeKind.Local).AddTicks(5991), true },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3959), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(3961), false },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 24, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(6466), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(6467), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 13, 59, 57, 139, DateTimeKind.Local).AddTicks(7456), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7458), true },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(2919), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 5, 59, 57, 139, DateTimeKind.Local).AddTicks(2921), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 23, 18, 59, 57, 139, DateTimeKind.Local).AddTicks(3492), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(3493), false },
                    { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(3968), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(3970), false },
                    { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 4, 59, 57, 139, DateTimeKind.Local).AddTicks(4489), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(4490), false },
                    { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 19, 59, 57, 139, DateTimeKind.Local).AddTicks(4997), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(4999), true },
                    { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 23, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5515), "Cachorro muito bravo, tome cuidado", new DateTime(2021, 2, 26, 11, 59, 57, 139, DateTimeKind.Local).AddTicks(5516), false },
                    { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(5994), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 16, 59, 57, 139, DateTimeKind.Local).AddTicks(5996), true },
                    { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 1, 59, 57, 139, DateTimeKind.Local).AddTicks(6470), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 24, 23, 59, 57, 139, DateTimeKind.Local).AddTicks(6471), false },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 23, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(6933), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6934), false },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"), new DateTime(2021, 2, 24, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(7460), "Não vi cachorro nenhum, deve ter sido um bug", new DateTime(2021, 2, 24, 22, 59, 57, 139, DateTimeKind.Local).AddTicks(7462), false },
                    { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 24, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(2925), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(2926), false },
                    { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"), new DateTime(2021, 2, 24, 0, 59, 57, 139, DateTimeKind.Local).AddTicks(3496), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 14, 59, 57, 139, DateTimeKind.Local).AddTicks(3498), true },
                    { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"), new DateTime(2021, 2, 23, 7, 59, 57, 139, DateTimeKind.Local).AddTicks(6928), "Vi o cachorro, mas ele não latiu, acho que bugou", new DateTime(2021, 2, 25, 21, 59, 57, 139, DateTimeKind.Local).AddTicks(6930), true },
                    { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"), new DateTime(2021, 2, 24, 3, 59, 57, 139, DateTimeKind.Local).AddTicks(7750), "Cachorro não atacou, alarme falso", new DateTime(2021, 2, 25, 8, 59, 57, 139, DateTimeKind.Local).AddTicks(7752), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("001cf859-2833-4e35-99b3-078182dc9649"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("01167724-ced8-42cd-812c-19e5ae648027") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("026c0281-051e-4e62-8486-8d1ca2633f41") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("033fed00-e679-4053-a1d5-1693a1333d74") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("041c4317-352e-4b56-9f25-d482fe21c595") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("0e091043-cce4-48d2-86ef-b3113901f83b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("111534e5-15b2-4615-bf46-6cfd39d06274") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("122f1361-2561-4ebf-92df-24f97a8dd284") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("17236614-466d-480f-b238-2117af38f6f9") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("2c3ce8b9-1100-4805-be02-503ee3338483") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("33f27363-0c25-4010-8449-0b67bd423b64") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("38311f58-2673-47de-a2a4-f42ba62277c8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("48f5c708-74d4-4a04-892e-6202a12715ac") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("62022881-ad46-42c7-b730-31482d928876") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("62614528-fa10-43dd-a6b4-24682dff743c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7113bc13-5419-4bac-a2f6-80050a912955") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("881e009f-8b8b-4df0-a020-7d84adb17721") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("937afd84-ca89-4663-a40f-a58414bd8507") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("940b0799-30c1-4828-8a54-381ea1857e22") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9a613057-d022-4d7e-a302-739f770ce1ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("afbfcde1-35b4-4b08-8b6b-194150736236") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bd280658-0555-4375-8590-1ce51e9a201c") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("bf2a6999-db79-4a54-aba1-198aaf481055") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("caed513a-83af-4de5-9f4c-76db8df368d2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("d0b079b3-f690-4024-922b-e7acc28ba032") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dd5cde36-7e2b-4923-988f-4e6906633758") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ead94c83-4597-437d-b4f3-edf851e176f2") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fba34323-f788-4051-a603-e22715e94671") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a") });

            migrationBuilder.DeleteData(
                table: "UserNotification",
                keyColumns: new[] { "UserId", "NotificationId" },
                keyValues: new object[] { new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"), new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4") });

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("001cf859-2833-4e35-99b3-078182dc9649"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("128dda0a-987d-47dd-bc3f-9bd257f4b3eb"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("2b04feaa-ba78-4371-8fcd-c21a4f3d3f4c"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("3f00cb54-1534-44fa-b3ed-a1f4e1e0666a"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("4a7e94de-409e-4dd7-bfc9-1e3cc9d10702"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("7db89cd5-f43f-4e02-ad0a-91ea800d4737"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("adce276a-fb10-44a8-a6fc-4f0e51f5398c"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("d07b505e-31cf-48fe-a8d4-b02ec9976d3f"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("d2b1954c-1c63-49f7-88ed-f6bb99db4461"));

            migrationBuilder.DeleteData(
                table: "MobileUser",
                keyColumn: "Id",
                keyValue: new Guid("eb4c08d5-9818-4d23-b349-0baa52e29d73"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("01167724-ced8-42cd-812c-19e5ae648027"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("026c0281-051e-4e62-8486-8d1ca2633f41"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("033fed00-e679-4053-a1d5-1693a1333d74"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("03c8ab92-fba8-4782-8b85-da4b630c98e6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("041c4317-352e-4b56-9f25-d482fe21c595"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("04cf9cd6-e10e-4dfa-9071-c84b1a75a883"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("0e091043-cce4-48d2-86ef-b3113901f83b"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("0ec365e9-2fbe-4b05-8bfa-7b5e746694f6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("111534e5-15b2-4615-bf46-6cfd39d06274"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("122f1361-2561-4ebf-92df-24f97a8dd284"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("15d28b54-e357-452e-8bca-5be3dba1c42b"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("17236614-466d-480f-b238-2117af38f6f9"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("1793b635-dc1d-41d8-8669-7e43c4f4da48"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("2646f299-dc9a-43b9-af2e-7952b76138ad"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("2b69fad7-e99a-4d0c-965c-1d6f99e880b7"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("2c3ce8b9-1100-4805-be02-503ee3338483"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("3034748f-0699-4ee5-b912-c9f79cb0029f"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("31f8bf30-d892-4c8a-8230-e26f79b0d2db"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("33f27363-0c25-4010-8449-0b67bd423b64"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("345d0b7f-ea95-4fa2-bbfb-6fdeee08d757"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("34c74b61-ddf6-401f-8f32-737948dc4c7c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("35cbd546-bc46-44e2-aa89-8d087eaa1be3"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("38311f58-2673-47de-a2a4-f42ba62277c8"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("3a2ef0ce-6a1b-43ec-a48a-427a1adb45d0"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("48f5c708-74d4-4a04-892e-6202a12715ac"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("4dc620ad-78d4-4906-ae3d-ea3ea1e1a72a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("4e4ce71a-0ac4-43ec-a10b-bde9ed11920b"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("4f02d5ab-f19f-4656-b706-c14ce1783685"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("591b1cb2-339e-4b02-b390-1127c9b7eaf5"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("592a42c9-d0df-437b-b3e1-2f7a8d284e33"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("5d426491-b337-4cdf-a1d0-1493b7622a6c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("615ae8f3-58ef-440f-ac3e-b0e4363fae54"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("62022881-ad46-42c7-b730-31482d928876"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("62614528-fa10-43dd-a6b4-24682dff743c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("644e68de-bd14-4d07-84cc-abd26e2afc50"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("64808957-e3df-4a5d-9557-1c6bbfbe156d"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("654f4680-c9dc-4904-bcda-c32f9be348d2"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("6aebbdee-e0f2-4748-8905-21b6cfe5ff21"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("6ff8df97-cf62-4e0b-8e55-70f50b60aa23"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("7113bc13-5419-4bac-a2f6-80050a912955"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("747fd044-2275-4070-a3ff-e8c3fdc92866"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("7b5b654b-e801-4f02-9dba-b8a22daf80b0"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("7f2eb42e-a46c-426a-afa5-b07f9fd61f78"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("80225a8d-57df-462b-bbd6-12ebb916a3e6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("81b816cd-5f87-4b8d-9cfb-de4f6cb3708f"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("86368ac0-218c-48fc-a4e9-b137a93dd3e6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("881e009f-8b8b-4df0-a020-7d84adb17721"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("8af80750-50b8-4d4f-9993-ad534cdaf222"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("927e3489-99e5-4e7d-a641-1c1e1fcfd1ca"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("937afd84-ca89-4663-a40f-a58414bd8507"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("940b0799-30c1-4828-8a54-381ea1857e22"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9589744f-eafd-4c62-9822-cd4cda4888fe"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9641d3fa-0157-4b0f-ab40-812948add6e1"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("98fa32eb-931e-4081-a2af-6d8003bc1ff3"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9a613057-d022-4d7e-a302-739f770ce1ad"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9bdd7918-bb25-45fe-9757-87c42e67d3b5"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9d766a8c-c5c2-4ab7-94a1-728c4e1d4e60"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("9d956814-2de2-4f9a-b5c3-f85613b965cc"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("a3acee54-ac17-4aef-98ef-d525195d95ad"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("a58d05c1-6aa3-41b2-94dc-28149af8f8bb"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("a6ae9a6a-5521-41a8-8ead-b32e1b3d3ccc"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("a7fa23b8-e811-4524-81bd-0818e74f125d"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ad4fdd10-f08c-47ec-8912-e2de152ca85a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("afbfcde1-35b4-4b08-8b6b-194150736236"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("b0e25ed8-c907-4fcd-8b60-17a799cd7f3c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("b28db8b9-bc93-42ac-aea2-a79201bfb022"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("b983c85c-6b99-4890-acd0-f92f5c8e8088"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ba0a73b8-14ec-4817-90b6-1333f991f32d"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ba79b6f0-6c69-468b-bdc8-f5b6c5484543"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("baacbbf4-f030-4dbc-b21e-9a981dfb57e6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("bb224d3c-7bda-4269-b36f-6c13d34197a4"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("bd280658-0555-4375-8590-1ce51e9a201c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("be771257-dc86-4346-9fd1-7a9485ca0c35"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("bf2a6999-db79-4a54-aba1-198aaf481055"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("c315ea99-29d1-45e6-a5ad-70fcd1c31ffc"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("c4518376-e028-4233-88d4-fdae0d9a0e92"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("c6c00a65-1dd3-4a28-8c79-b422cfe88e89"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("c83a7982-49b4-42c7-b25e-0bb10c26b5d8"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("caed513a-83af-4de5-9f4c-76db8df368d2"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("cb471c9d-be32-4513-9087-6ddd403d6a20"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ce60be73-1873-4f7a-aed7-b5a858a94c66"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("cf99d513-bdd4-4b6a-8a2b-6a59b7bd7775"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("d0b079b3-f690-4024-922b-e7acc28ba032"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("d79d20c8-76c0-4155-84ea-8f094a8e7b88"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("dccd893f-942d-4dba-8e61-66ce68e0d053"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("dd5cde36-7e2b-4923-988f-4e6906633758"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("dd72dd20-e3ab-498f-adaa-ba218f3b0f59"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ea10b27d-601d-41e6-bdab-d7a5eff50deb"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ead94c83-4597-437d-b4f3-edf851e176f2"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("eb0209d5-812d-4b16-8894-10a8682ccea4"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("eb202152-ee13-4c5c-9967-8a81cb950de5"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ebd79bda-1d07-4b51-bbf8-e8a0359685c6"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("ed8b6632-f945-45b1-a5bf-fbdf1704b2b1"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("f0a6edda-a4ed-4a33-85ac-5072722da62a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("f93e3a8f-abfb-45d2-b413-d15f2e4b9caa"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("fa02dfd7-6f4b-4656-8e0c-96d2a920cc7a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("fa5a3664-cc34-4fb9-8ff4-3e93ead93ced"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("fba34323-f788-4051-a603-e22715e94671"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("fc242a26-93c7-4b1b-8eab-3d6f8f8ff33a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "NotificationId",
                keyValue: new Guid("fdd0ba25-f5fc-4382-b98b-dc78947a17c4"));

            migrationBuilder.DeleteData(
                table: "Collar",
                keyColumn: "DeviceId",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "Collar",
                keyColumn: "DeviceId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Collar",
                keyColumn: "DeviceId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Collar",
                keyColumn: "DeviceId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Collar",
                keyColumn: "DeviceId",
                keyValue: "4");
        }
    }
}
