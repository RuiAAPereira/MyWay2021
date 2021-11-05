using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWay2021.Server.Migrations
{
    public partial class formacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormacaoConcluida");

            migrationBuilder.DropTable(
                name: "Justificacoes");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("03a1fab5-4643-4b17-b2eb-520b8fc36296"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("0f8ac595-8519-481c-b344-0725614ab726"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("0fbef165-cf17-4556-81f2-ff4921c5ceab"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("1260c1f1-cd4b-4456-9817-038efb01ee88"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("130e0344-aea1-4e62-be2e-b88ae5a6d798"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("149f15d5-fa7f-43a9-8a85-8b95228510b0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("17161fda-268f-443e-8191-765b836c2f0b"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("1ce714d5-05f6-45b7-b041-c3ddba65e76a"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2dadf1d5-d924-40d9-a504-880b1d476f50"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2fed30c4-a929-494c-be60-cc1349e73700"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3066ba72-b901-4ca8-a5ce-35838877e260"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3249e790-aa36-4257-92cf-6e03e190255e"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("34c1c21c-641f-4e23-8c59-0fff42a2c5bc"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3b783982-e915-49a8-a732-f5e8590cfe98"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("44ebca02-6308-4263-8df3-f877c54e1287"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("4cc927f2-b479-4452-bfa6-f5b11f93ee3d"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("6270e3ca-c0f6-49ea-a859-f92003dd0c2c"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("6ca10b2d-17d5-4adf-8a4c-aa152f527b7e"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("70457970-acd6-4b78-aeeb-08be4d587f5a"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("710c59c5-842a-4684-a9ac-1faf9ec41c9f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("72ae58e7-d855-478a-9659-6d71662f21c3"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("74d89aaf-9f0b-4160-8763-5794abf0ea97"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("75b75d72-5c5a-4182-b9da-b4932f5b2138"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("769c7105-8ec4-452b-a515-3e486baffc36"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("7cc31793-4136-4a15-8cc9-f1d4e7e3845d"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("7f62bef3-60bb-4f92-bb27-03c0d05d80ad"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("859111f2-24d7-479f-99a7-b24bf0fdcaae"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("86834510-9eb0-4fec-ab7c-0c3be5bd97c5"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("8e3c1dc8-0b0f-4845-8602-0978157c06b9"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("9045da3d-fcf8-41d2-8fd6-0ac38a906df1"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("91d5377a-0ae4-40f1-b360-b6fb3a4b320c"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("940d1d2f-9c04-4f45-8331-9de7426165de"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("951b155a-efff-44e2-b838-31f82e4f8e7f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("98f9892d-b914-4850-b95a-07b21ca72e82"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("9caf61d2-8605-4d96-8f4f-418e2cad5605"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("9d91c221-1c82-4c85-ba58-24c08cbed6e8"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a2d69fc9-3596-4f21-a5cc-368dbd055aa4"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a3b13068-1867-49e7-85ed-69358f4cf338"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a41ad9c4-3baa-4e57-b56e-6e3c26d94716"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("af5e473d-5b7f-493c-91ab-391bb44e4f25"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("b7e056b3-6f95-4758-8d20-c11a205f8ef0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("b8fffb68-6247-4a8f-8f83-91ea666684ae"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("bd04535a-e075-4e90-8ac1-64e14fec2159"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("bdd77293-241a-40a2-9137-fcb6049326e4"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("c49f4cd9-9b67-467e-be0e-40c9eb6cb1b7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("c52f257a-5edf-4032-acfb-27cd3932a5aa"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("cad9278f-fac7-46b2-ae30-40fea89aae74"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("d41cb7fc-5327-4741-931d-33a3d20c18de"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("d6d1ebab-b219-4333-9afa-fa24eb0e60b3"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e1568890-8201-499e-8bcd-5d4ebe71b142"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e171f1e1-e4a8-4f2e-bba8-a689631c95ca"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e3cafd63-72fb-4583-b24a-2ead1549aea5"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e5aa88f5-9358-418a-8143-85a0f7f143bf"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e68f328d-fd8c-4650-b4ad-be83a41f4520"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("ecb2042b-90cf-466a-856c-d3f110d0b4bf"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("edacd1fd-032f-4a2f-aa38-afe0169a495f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f037f2f0-0136-49d7-a90f-56bb0d14a369"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f25ec45f-91f5-46c4-8048-b20d4bbdc24b"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("fb90f70a-85f9-498a-8a55-1ae3654d91bc"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("fbaf5ba5-8fd8-4ff2-88fa-8f57a5b0a9a7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("fc007a64-ce8e-4d7f-ad2a-e3825cda1575"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("fef07bef-eb16-4426-b284-cb747d6789a9"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("01017935-35bb-4c19-ab19-5efcd37e8d77"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("02dcf2b6-8ed6-42f4-9769-d9d5cbd088ac"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("06f00af9-e496-4738-99b5-5616ef8d9f0a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("09f886a8-b7ed-483b-9108-9a15588c1bc5"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("11e7de6d-43cb-4e4f-8ad8-e4a93cfc625b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("127f70c7-fb15-4781-a733-9167f1fc9555"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("14be9c74-66e9-40a9-9881-e9c12ddc2dcb"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("15a3f7c5-7a0e-4c7a-8a6f-73c506ee88ad"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("17ed82ab-41d9-4fed-b6e7-15a323f8dada"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1bda327a-b137-414c-9500-3ba683be5d1b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1c59ac04-d166-4605-b32e-0acd9d175f16"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1c80b975-74df-4de9-ab85-75269963fe8f"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2271a327-6e36-49a9-ad3b-9b4fac627967"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2a8a789c-f8f8-46b9-be44-8a7483d287d3"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2cc44d5b-ca28-4e41-9f98-7d63c2eeaac5"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("34f27809-fdb9-48b4-b6f6-eec47bef3e57"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("421d9711-c2fe-414a-8ec6-9bf4c28b6ad2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("42814768-bda1-4537-82ce-233d9a651239"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("4400e4fc-3468-44cd-bfe7-3d8f04e03f01"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("46deaef9-0ccc-431a-9f92-63591ae966c4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("48be98f3-d900-4d1e-972b-9605c86e2053"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("51c745b4-ea45-4568-a681-a2a9bb2c1124"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("51fd905e-bbe4-4ad9-b48b-a16ce2a99f4c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("532fb788-8e5a-4336-80b8-b4a139a64fed"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("555aff86-3c88-47a1-ad9c-963ae36f31d4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5648c64f-d93f-4fcd-bc21-c6f45dd89f84"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5676f225-45d5-438a-9e14-e94524e2fba0"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("58c803ec-b007-4364-a28a-f78a521ef304"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("599fe2c6-a923-4f7f-ac75-e7339e3a9abd"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5ae15ea1-12b6-40e3-b59b-261eb3efd136"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5db0a72a-3381-4f43-a6ff-d1b11870bcc8"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5f83ac5e-6ca5-4aa4-a243-de44b797b74e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5fd29953-bf2e-4784-90d7-599c22b4d1ea"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6638cea8-3eee-4e20-8921-f97c2e0a6b42"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("66e88b53-defc-42e9-949f-adf4a691865e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6892bd55-44e4-48f7-a011-3f1d5778776f"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6cc9a02c-01da-4997-8af1-07e366626634"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("71743bbf-d61d-4782-96e4-a88290441231"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("72649504-7c95-4b6c-9336-8449779d0c4d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("749e4ed6-6e90-4f0e-9d6a-75e7080975f4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("78aed538-36b6-473d-9ebd-492c69176ac7"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("79cdbdab-c435-4925-b551-b7599845c8b2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7a86b496-7211-41d3-a319-b8669feab78e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7c107e84-e44f-4d4b-a091-d437f3b31f36"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7d931b73-112c-42ad-bfbb-a33b69f9eb07"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7df823b8-35b2-4e18-9cf8-9a709baa2ce4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("80563d90-44d8-4dae-93f4-5f775fac5177"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("836a4883-c015-469d-b6a2-2108fd6f838c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("842356e2-eea5-4f18-b91f-26e10aabde7e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("849ccd7d-b65c-4f43-8c37-191b237b8a07"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("86279fd1-beb7-4911-981b-573167eb6ee5"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8a80edf7-5fa8-4b72-a7ce-871b8b87e596"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8f95f9e1-eedb-4060-928d-8b757ef18a84"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8fd5e382-68e0-4170-ba0c-8585e7540d79"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("91237d37-9362-4932-8960-97f195191a8b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("95361bfd-c682-42c4-8396-5c09bd74addc"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9647ffb2-e4e0-48c6-9911-14f20a5477d4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9af9a9ad-25a3-4050-96b5-5fd39a039f89"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9c6e35f6-b727-4e8f-b2c5-1cef21e4488d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9cddf05e-6547-4a46-80ae-ecf6931f1515"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9ee07069-cca4-4350-acfa-1cd8a3811807"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9fc21a6a-5ba2-422e-ae7e-94aa51aaa921"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("a9dfe146-6e02-4baa-817e-9768d4a59b6d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("acf8a358-30e4-4d2b-aeaf-70c10ef3cc7a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("ad49e988-a53d-4fe2-bde8-ee013e25ac6c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b1cec3ad-5009-4011-9d71-a3b0bfa5ded2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b5453618-deae-4fc6-97b7-9f1ca78435bc"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b8e39f1a-bb36-4356-8832-75a5bc997ab8"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b8e83dd3-e47f-4e77-ab40-64d7d1eb2df4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("c58d3406-d98f-4db1-acf6-28cb8b1485a8"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d0dff326-d21d-4b8c-9212-bc8f9fa512ff"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d3e33ecb-2e0b-49b7-b02b-26bff1e0f889"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d8753ce2-bbbd-4990-a6d9-3ccff77f4449"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("dbe64307-0d49-4c99-b0b1-c214ce942952"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("e3b865b4-6083-4c2d-8e36-e0e5a9533328"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("e8e69e70-ca8c-4e94-a2af-5033b50154aa"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("efcb6290-ca82-401d-915f-04219a4d2d0a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("efda688c-bf72-4d84-b479-b07b6a744681"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f0f5ddfd-d61f-4311-8f30-6ed8709843c9"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f2ef57c3-6a81-4890-a732-da2f3efb4389"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f31d41bf-e261-4074-bf9f-8857026d9fb2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("fb72d15b-0695-4d17-9ab3-d7f2108ac333"));

            migrationBuilder.DropColumn(
                name: "DataAdmissao",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Colaborador");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartamentoID",
                table: "Colaborador",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AccaoFormacao",
                columns: table => new
                {
                    AccaoFormacaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColaboradorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CursoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAccao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccaoFormacao", x => x.AccaoFormacaoID);
                    table.ForeignKey(
                        name: "FK_AccaoFormacao_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "ColaboradorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccaoFormacao_Cursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "Cursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartamentoNumero = table.Column<int>(type: "int", nullable: false),
                    DepartamentoNome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoId", "CreatedAt", "CreatedBy", "DepartamentoNome", "DepartamentoNumero", "LastUpdatedAt", "LastUpdatedBy" },
                values: new object[,]
                {
                    { new Guid("f029ae62-42e2-45b5-ae2f-db2c8cbd92cc"), null, null, "NILL", 0, null, null },
                    { new Guid("a9f1e790-5a03-4d2f-8b4c-ac4049f29223"), null, null, "MYWAY", 0, null, null },
                    { new Guid("fc6c7a4e-0b99-4d31-b9f4-c465e785d3dc"), null, null, "PLACA", 0, null, null },
                    { new Guid("ee0bc74d-70f1-443a-a269-7c4c650578f4"), null, null, "CARGA", 0, null, null },
                    { new Guid("cebd6da4-8139-4f95-8b4b-2d8ede54acce"), null, null, "PASSAGEIROS", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("43bf885f-ec78-494a-8bca-a534f09492e3"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47A", 16, true, false, true },
                    { new Guid("3fe43786-2c83-441b-bdd8-6363f63a4ad0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47", 16, false, false, true },
                    { new Guid("d741f2e9-2d47-4a45-ae5e-5a5942acb3a0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46A", 17, true, false, true },
                    { new Guid("2240751a-ee56-4791-9d1c-272b6e6a83ba"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46", 17, false, false, true },
                    { new Guid("528b8369-d8d3-4170-ad7c-9e4bac9148c6"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45A", 16, true, false, true },
                    { new Guid("975ece3b-a748-471f-9e3a-3936ec28125d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45", 16, false, false, true },
                    { new Guid("611766b9-9195-4c14-b2d2-c11873e68403"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44A", 15, true, false, true },
                    { new Guid("4d1b3b11-0ea2-411b-a67f-91f5a2c3dab7"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "201", 10, true, true, false },
                    { new Guid("3cb8f991-61c8-4c48-b92c-be484a7877cb"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44", 15, false, false, true },
                    { new Guid("9749836a-c7b4-4957-baaf-b1826447261a"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43B", 14, true, false, true },
                    { new Guid("b2489af8-938c-471f-8beb-08a3700b110b"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43A", 14, true, false, true },
                    { new Guid("5308e667-1410-4740-a6bb-e1387648ada0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43", 14, false, false, true },
                    { new Guid("eefcb5c7-6bcf-4d00-bb7d-4c04bfd92073"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44B", 15, true, false, true },
                    { new Guid("19e58750-536f-4946-9fba-87cb5dd834d7"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "202", 10, true, true, false },
                    { new Guid("f0a36c56-eead-4a5e-956e-5b2f395d1c59"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "204", 10, true, true, false },
                    { new Guid("67d5666c-5e03-42d9-91e5-1c1c7bca8a35"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42A", 13, true, false, true },
                    { new Guid("0233c690-2c75-4081-8f3e-4ecb5e4cc0f7"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "206", 10, true, true, false },
                    { new Guid("526cd346-740c-4700-9975-eb54163f8ca4"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "207", 10, true, true, false },
                    { new Guid("f5e9efcd-1e24-4ffb-b276-e7dcd5f5ddfb"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "208", 10, true, true, false },
                    { new Guid("39c1df72-9765-43ba-b56c-ef6704858947"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209", 10, true, true, false },
                    { new Guid("ca9d15ef-dedd-4a67-b5cb-bd77a008cf2f"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209A", 10, true, true, false },
                    { new Guid("3b8b366e-8577-4144-860d-3872758df9a2"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "210", 10, true, false, false },
                    { new Guid("a43e45a9-5f71-4cf9-b738-f79d716c5be0"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211", 10, true, false, false },
                    { new Guid("884ffb6d-34f3-4c21-b348-266e318efff3"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211A", 10, true, false, false },
                    { new Guid("ae385f82-c339-4cfe-89b9-bbc2f267d56d"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212", 10, true, false, false },
                    { new Guid("6ab00e7d-d60b-4b5e-b930-87e1b6fa5a7c"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212A", 10, true, false, false },
                    { new Guid("fd762c50-b91d-4bde-b3f3-ac3779864841"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214", 10, true, false, false },
                    { new Guid("a37df70e-4245-4031-90ae-afe5fe19c7f1"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214A", 10, true, false, false },
                    { new Guid("e16eb1a8-6cd3-4871-86d4-a5f044f747c7"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "203", 10, true, true, false },
                    { new Guid("be977149-943a-44a0-8372-03bd3778518c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42", 13, false, false, true },
                    { new Guid("a245469f-4b15-48f7-aacc-4d214e8128ee"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "205", 10, true, true, false },
                    { new Guid("2e6a5d44-3f9a-41f8-9bef-216ebad57c5f"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41", 13, false, false, true },
                    { new Guid("e6692d81-cdc1-4849-acd2-6e29903e4761"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41A", 13, true, false, true },
                    { new Guid("0d403fb4-72b8-4d9e-b41b-c84de562bd31"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "07", 12, false, true, true },
                    { new Guid("b08ff726-21f3-4e45-9c88-c1b6c96686b8"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "08", 12, true, true, true },
                    { new Guid("7daf6162-bf9f-4304-a9ba-0471d1909eee"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "8B", 12, true, true, true },
                    { new Guid("9a6bf04c-930e-4d55-a18b-6532dcf1e3d9"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "09", 11, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("f62906f8-f196-47f8-a6c5-56fb817df84f"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "10", 11, true, true, true },
                    { new Guid("b567f1f3-a008-4174-b7ff-7931f91d9ceb"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "12", 10, true, true, true },
                    { new Guid("e9e6d050-00d2-41fa-93b1-55bb4bfd6116"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "13", 9, true, true, true },
                    { new Guid("5beb8669-b8b9-46d2-804f-160c69234af8"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "14", 9, false, true, true },
                    { new Guid("931a9524-5ca7-4535-a64a-a26a591c3f84"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15", 8, false, true, true },
                    { new Guid("c6303445-08f4-4f45-ba1a-0ad6c943e937"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15A", 8, true, true, true },
                    { new Guid("92cb123d-20e9-40d3-a27a-667ecb5cf213"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16", 8, false, true, true },
                    { new Guid("f9266fdc-c355-4ce4-87fa-811c0eca34d5"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16A", 8, true, true, true },
                    { new Guid("2bbf18fc-ffad-42d5-a170-0ec5e1285cba"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17", 7, false, true, true },
                    { new Guid("09aade32-1e3a-47b6-8184-9ae7093b2be5"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "11", 10, true, true, true },
                    { new Guid("699a93cd-12fe-41b9-87c7-9e077abd871a"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18", 7, true, true, true },
                    { new Guid("65154c95-2cef-41b7-b3a6-a27feecf9839"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "27", 12, true, false, true },
                    { new Guid("dd6bc7a4-aeee-4f51-bfbe-3a85a5507019"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17A", 7, true, true, true },
                    { new Guid("481f7fc1-a887-45a5-be80-40890fc58aa2"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "26", 12, false, false, true },
                    { new Guid("4f817eab-7382-4e35-8adf-6c8a9e2a02cd"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "25", 7, false, true, true },
                    { new Guid("5388ca2e-32f0-4066-9d05-1bce67e743a4"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23A", 5, true, true, true },
                    { new Guid("c318182f-2d5a-4856-b9c8-474f692d25b4"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23", 5, false, true, true },
                    { new Guid("72978743-b5ba-41a4-8ad8-caf175cf6449"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22A", 5, true, true, true },
                    { new Guid("8df88a1b-adae-4cca-85b4-ed82b1d5d889"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "24", 7, false, true, true },
                    { new Guid("440e5fe6-a371-4b03-976b-318f231fd54c"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "21", 6, true, true, true },
                    { new Guid("34386e62-76cb-415c-a0c0-8778a7cefc33"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "20", 8, true, true, true },
                    { new Guid("ce79455b-ce92-49a8-b800-de2e8b6c6f95"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "19", 8, true, true, true },
                    { new Guid("1a7291f4-66d0-4720-8e3a-d8a9c8f38d82"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18B", 7, true, true, true },
                    { new Guid("6a6d6bf1-bc14-488a-a6be-55788ec68837"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22", 5, false, true, true },
                    { new Guid("2b0f61a7-463d-4bd6-aa09-383d8001fd37"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18A", 7, true, true, true }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "e2c2df12-2d9e-4614-bd1f-6d4d106d880a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "cbc6e659-e784-4b50-b904-a5852dea3215");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "68104067-9c3a-4305-b522-d07191330b6f");

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("1e67c02f-634f-4358-a65c-640058c89fec"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 505 },
                    { new Guid("412e2593-3b2b-4258-801c-300f0d46ad07"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 426 },
                    { new Guid("13b4ccf0-7d97-4ee0-8ff6-4fcf3eeed51a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 501 },
                    { new Guid("03ffcf83-9ac6-4658-9f05-dd65e3a5e75d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 506 },
                    { new Guid("c328663f-d29f-4e45-baa7-67ceb4432de7"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 503 },
                    { new Guid("d9ac239f-afc3-4d13-9101-c71fe703005a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 504 },
                    { new Guid("7fdecfff-3b93-4ecc-b67c-44e649c25923"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 502 },
                    { new Guid("af95369c-bbf2-4475-aa06-83532aaa0feb"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 425 },
                    { new Guid("97c01b3a-c65d-4064-96ac-52c634552b0b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 414 },
                    { new Guid("6d1982ea-34e7-4199-94a2-2a2891ae7a19"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 423 },
                    { new Guid("6fe83343-91c9-40e7-bd21-c4ea9d636a7a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 422 },
                    { new Guid("d93fdd1a-1dfc-4fe2-8730-3139e36d215d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 421 },
                    { new Guid("15d12989-dc7c-49c2-9152-be8865a36388"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 416 },
                    { new Guid("f63a9d44-30f4-4ed7-b807-030df61c7929"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 415 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("2d973a11-3ef3-46a3-a87f-065f9af2e8d8"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 601 },
                    { new Guid("3a5a9703-54d7-4403-892c-c1ec8584b5c4"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 413 },
                    { new Guid("bf5babc9-c6ae-4026-8451-aaee1bcc7688"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 424 },
                    { new Guid("a78d4eef-5c5b-4558-8237-b37eee92b057"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 602 },
                    { new Guid("0c5c56bc-2b0b-4031-9a03-be9fc32064ea"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 803 },
                    { new Guid("dd917ade-9d79-4dfd-8789-0d6a0e682a31"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 604 },
                    { new Guid("1cd5bf68-b559-4c09-a7bb-8a9c5b493e01"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 412 },
                    { new Guid("b06f4dd4-067f-474d-a765-709d3a201d0b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 806 },
                    { new Guid("75651fbc-3708-4cc1-9835-e4086cd854f9"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 805 },
                    { new Guid("32af8d1e-98fa-4bb5-a826-0ff3b824a5d4"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 804 },
                    { new Guid("266c949f-ddd6-4df9-8368-5746be5cc6ba"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 802 },
                    { new Guid("ed46a2d8-b6f1-49b1-ae45-263cb04537d7"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 801 },
                    { new Guid("fb022792-c57b-4a8e-b1df-841fec6c6345"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 706 },
                    { new Guid("554e77d5-2b5e-4aac-b302-e78bb9bd598a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 705 },
                    { new Guid("b735d9a6-e8bd-4ad4-ab09-12c92bb0d7af"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 704 },
                    { new Guid("eff4e6d2-e238-4f1b-bde8-24c140ed7905"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 703 },
                    { new Guid("0a818736-6bb4-49f7-8d04-a8dd8fd0c88c"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 702 },
                    { new Guid("e27840db-375a-453a-b4f8-e49a67ff2bdd"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 701 },
                    { new Guid("1fdd912d-41a0-4307-8d0a-63d96b15e180"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 609 },
                    { new Guid("8cbf4ed2-cd25-40d6-a537-ba1b74aa46b0"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 608 },
                    { new Guid("ac87bebf-2899-4ae5-b8e4-792adb8ab006"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 607 },
                    { new Guid("0ca45e9a-d1f4-48de-bcf1-b30b3fcb22a2"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 606 },
                    { new Guid("5b3864a1-2982-497a-8ef6-6f7cc073f899"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 605 },
                    { new Guid("7a3d3da6-5eee-4c74-b3d5-e225acc930a5"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 603 },
                    { new Guid("ce65549b-0d1e-4a5a-9f0f-92122ac62bea"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 411 },
                    { new Guid("977b163a-2cac-4692-9056-4e789c22357f"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 122 },
                    { new Guid("44cee191-e377-40ad-a186-9243f8db09e1"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 404 },
                    { new Guid("1e22d366-cb25-40d0-b079-8fc4b3853c56"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 145 },
                    { new Guid("f00b2fce-f35c-464d-9461-9ed375f8035d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 144 },
                    { new Guid("e6812657-b7b6-41de-9615-f482b89d322e"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 143 },
                    { new Guid("f16d7024-1fac-46af-a369-7b121acb7c9d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 142 },
                    { new Guid("82286ee3-de75-4bfe-a6de-ebc75669ff7d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 141 },
                    { new Guid("6a85332d-a303-4631-b9d5-78b59607ff52"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 126 },
                    { new Guid("ba685c20-25a8-47f3-8a93-cbe70af8b84f"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 125 },
                    { new Guid("d9819f41-94dc-4094-846d-d18393d5ce5a"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 124 },
                    { new Guid("6080b766-7094-47b2-be1a-663c61f5c9ac"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 146 },
                    { new Guid("7a96c37b-c282-4ca2-b332-eee5612c7617"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 123 },
                    { new Guid("8b04510d-303f-4312-9ee6-cfd194573805"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 116 },
                    { new Guid("cfbfac8e-211b-4a24-a5d9-398d63152c6a"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 115 },
                    { new Guid("f3ee49f7-aa8d-4380-97a6-e73f84466960"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 114 },
                    { new Guid("dbb1e519-cc93-49eb-b32e-0666d7fadb2b"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 108 },
                    { new Guid("c7996b7f-7c8a-4b86-a649-27e2b9725bbf"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 107 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("8215386b-e6cc-47c9-897e-ddc7215c79e2"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 106 },
                    { new Guid("672182d4-c7e6-471f-86ef-7fef46078022"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 105 },
                    { new Guid("d80b35d5-7152-4bda-8d71-e844a295c355"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 104 },
                    { new Guid("f486dc1c-f508-468c-b7ba-94fd092ae60a"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 117 },
                    { new Guid("d820ff6b-5563-464e-9399-03b2fd0d8083"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 405 },
                    { new Guid("4b46caa6-d550-42ae-9da9-e6b3ed0ab1a0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 147 },
                    { new Guid("1d9501b6-6e7c-4a66-b8a5-9166731de776"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 201 },
                    { new Guid("c53735b1-b1d3-4980-ba31-00852f4b188e"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 403 },
                    { new Guid("7c23e599-50b4-4fb0-8c27-b23da4fff122"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 402 },
                    { new Guid("1f72779d-e2e1-4931-a067-64e329b0c687"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 401 },
                    { new Guid("e8797d8f-70d6-49a3-9d9a-9747e9ab91ac"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 302 },
                    { new Guid("2619bdff-186c-41d0-8531-e1982d02f864"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 301 },
                    { new Guid("a8c15d5b-8744-4284-b916-fc3d425fa0b7"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 225 },
                    { new Guid("62ee31ce-32dd-4dd2-91ae-1cbec5239c5d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 224 },
                    { new Guid("c6f8a342-4e92-4c47-896b-37e606d030ba"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 223 },
                    { new Guid("93915c58-f78e-4c54-8270-3d8352dab449"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 200 },
                    { new Guid("2da7614e-8e85-4f72-81d5-ce5b3112d0b7"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 222 },
                    { new Guid("d64927b8-0796-4bca-8e5d-b6198c9ca7fe"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 209 },
                    { new Guid("a202dce9-84a1-4afc-a83d-64c315912c04"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 208 },
                    { new Guid("38863b2e-fd5c-4127-93ac-9026ad946119"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 207 },
                    { new Guid("9cd597a8-27e4-4356-91c7-a262cf6e82f8"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 206 },
                    { new Guid("49dae0d5-3d1c-4f0f-bb67-3007992d8a1c"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 205 },
                    { new Guid("4ba73dd1-ee64-4f97-833c-f7575867bcf2"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 204 },
                    { new Guid("7182f252-b652-4769-8f26-347f5e9c2b2d"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 203 },
                    { new Guid("90abade9-7e84-406a-a32a-5b04421e583d"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 202 },
                    { new Guid("5abf5c41-6e46-4fbb-8fa1-74cc3664b89c"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 221 }
                });

            migrationBuilder.InsertData(
                table: "Uhs",
                columns: new[] { "ID", "CodAeroporto", "CreatedAt", "CreatedBy", "IATA", "LastUpdatedAt", "LastUpdatedBy", "Nome", "NomeAeroporto" },
                values: new object[] { new Guid("81cfd799-1cb5-4852-8123-845ae6da4404"), "NILL", null, null, "N", null, null, "NILL", "Nill" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9760a8f5-33a4-4af2-b530-3ec2d25021b3", "AQAAAAEAACcQAAAAEHbqDGl2pUIKXJF9tJ9XNuPt4J6lYSeUEvROUIwyhuYb6hhHLHJsYBC1Emp0NguDjg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_DepartamentoID",
                table: "Colaborador",
                column: "DepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_AccaoFormacao_ColaboradorID",
                table: "AccaoFormacao",
                column: "ColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_AccaoFormacao_CursoID",
                table: "AccaoFormacao",
                column: "CursoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_Departamentos_DepartamentoID",
                table: "Colaborador",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Departamentos_DepartamentoID",
                table: "Colaborador");

            migrationBuilder.DropTable(
                name: "AccaoFormacao");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Colaborador_DepartamentoID",
                table: "Colaborador");

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("0233c690-2c75-4081-8f3e-4ecb5e4cc0f7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("09aade32-1e3a-47b6-8184-9ae7093b2be5"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("0d403fb4-72b8-4d9e-b41b-c84de562bd31"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("19e58750-536f-4946-9fba-87cb5dd834d7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("1a7291f4-66d0-4720-8e3a-d8a9c8f38d82"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2240751a-ee56-4791-9d1c-272b6e6a83ba"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2b0f61a7-463d-4bd6-aa09-383d8001fd37"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2bbf18fc-ffad-42d5-a170-0ec5e1285cba"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("2e6a5d44-3f9a-41f8-9bef-216ebad57c5f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("34386e62-76cb-415c-a0c0-8778a7cefc33"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("39c1df72-9765-43ba-b56c-ef6704858947"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3b8b366e-8577-4144-860d-3872758df9a2"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3cb8f991-61c8-4c48-b92c-be484a7877cb"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("3fe43786-2c83-441b-bdd8-6363f63a4ad0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("43bf885f-ec78-494a-8bca-a534f09492e3"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("440e5fe6-a371-4b03-976b-318f231fd54c"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("481f7fc1-a887-45a5-be80-40890fc58aa2"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("4d1b3b11-0ea2-411b-a67f-91f5a2c3dab7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("4f817eab-7382-4e35-8adf-6c8a9e2a02cd"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("526cd346-740c-4700-9975-eb54163f8ca4"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("528b8369-d8d3-4170-ad7c-9e4bac9148c6"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("5308e667-1410-4740-a6bb-e1387648ada0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("5388ca2e-32f0-4066-9d05-1bce67e743a4"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("5beb8669-b8b9-46d2-804f-160c69234af8"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("611766b9-9195-4c14-b2d2-c11873e68403"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("65154c95-2cef-41b7-b3a6-a27feecf9839"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("67d5666c-5e03-42d9-91e5-1c1c7bca8a35"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("699a93cd-12fe-41b9-87c7-9e077abd871a"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("6a6d6bf1-bc14-488a-a6be-55788ec68837"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("6ab00e7d-d60b-4b5e-b930-87e1b6fa5a7c"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("72978743-b5ba-41a4-8ad8-caf175cf6449"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("7daf6162-bf9f-4304-a9ba-0471d1909eee"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("884ffb6d-34f3-4c21-b348-266e318efff3"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("8df88a1b-adae-4cca-85b4-ed82b1d5d889"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("92cb123d-20e9-40d3-a27a-667ecb5cf213"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("931a9524-5ca7-4535-a64a-a26a591c3f84"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("9749836a-c7b4-4957-baaf-b1826447261a"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("975ece3b-a748-471f-9e3a-3936ec28125d"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("9a6bf04c-930e-4d55-a18b-6532dcf1e3d9"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a245469f-4b15-48f7-aacc-4d214e8128ee"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a37df70e-4245-4031-90ae-afe5fe19c7f1"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("a43e45a9-5f71-4cf9-b738-f79d716c5be0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("ae385f82-c339-4cfe-89b9-bbc2f267d56d"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("b08ff726-21f3-4e45-9c88-c1b6c96686b8"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("b2489af8-938c-471f-8beb-08a3700b110b"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("b567f1f3-a008-4174-b7ff-7931f91d9ceb"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("be977149-943a-44a0-8372-03bd3778518c"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("c318182f-2d5a-4856-b9c8-474f692d25b4"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("c6303445-08f4-4f45-ba1a-0ad6c943e937"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("ca9d15ef-dedd-4a67-b5cb-bd77a008cf2f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("ce79455b-ce92-49a8-b800-de2e8b6c6f95"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("d741f2e9-2d47-4a45-ae5e-5a5942acb3a0"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("dd6bc7a4-aeee-4f51-bfbe-3a85a5507019"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e16eb1a8-6cd3-4871-86d4-a5f044f747c7"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e6692d81-cdc1-4849-acd2-6e29903e4761"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("e9e6d050-00d2-41fa-93b1-55bb4bfd6116"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("eefcb5c7-6bcf-4d00-bb7d-4c04bfd92073"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f0a36c56-eead-4a5e-956e-5b2f395d1c59"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f5e9efcd-1e24-4ffb-b276-e7dcd5f5ddfb"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f62906f8-f196-47f8-a6c5-56fb817df84f"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("f9266fdc-c355-4ce4-87fa-811c0eca34d5"));

            migrationBuilder.DeleteData(
                table: "Portas",
                keyColumn: "PortaID",
                keyValue: new Guid("fd762c50-b91d-4bde-b3f3-ac3779864841"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("03ffcf83-9ac6-4658-9f05-dd65e3a5e75d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("0a818736-6bb4-49f7-8d04-a8dd8fd0c88c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("0c5c56bc-2b0b-4031-9a03-be9fc32064ea"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("0ca45e9a-d1f4-48de-bcf1-b30b3fcb22a2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("13b4ccf0-7d97-4ee0-8ff6-4fcf3eeed51a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("15d12989-dc7c-49c2-9152-be8865a36388"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1cd5bf68-b559-4c09-a7bb-8a9c5b493e01"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1d9501b6-6e7c-4a66-b8a5-9166731de776"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1e22d366-cb25-40d0-b079-8fc4b3853c56"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1e67c02f-634f-4358-a65c-640058c89fec"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1f72779d-e2e1-4931-a067-64e329b0c687"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("1fdd912d-41a0-4307-8d0a-63d96b15e180"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2619bdff-186c-41d0-8531-e1982d02f864"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("266c949f-ddd6-4df9-8368-5746be5cc6ba"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2d973a11-3ef3-46a3-a87f-065f9af2e8d8"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("2da7614e-8e85-4f72-81d5-ce5b3112d0b7"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("32af8d1e-98fa-4bb5-a826-0ff3b824a5d4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("38863b2e-fd5c-4127-93ac-9026ad946119"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("3a5a9703-54d7-4403-892c-c1ec8584b5c4"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("412e2593-3b2b-4258-801c-300f0d46ad07"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("44cee191-e377-40ad-a186-9243f8db09e1"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("49dae0d5-3d1c-4f0f-bb67-3007992d8a1c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("4b46caa6-d550-42ae-9da9-e6b3ed0ab1a0"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("4ba73dd1-ee64-4f97-833c-f7575867bcf2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("554e77d5-2b5e-4aac-b302-e78bb9bd598a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5abf5c41-6e46-4fbb-8fa1-74cc3664b89c"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("5b3864a1-2982-497a-8ef6-6f7cc073f899"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6080b766-7094-47b2-be1a-663c61f5c9ac"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("62ee31ce-32dd-4dd2-91ae-1cbec5239c5d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("672182d4-c7e6-471f-86ef-7fef46078022"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6a85332d-a303-4631-b9d5-78b59607ff52"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6d1982ea-34e7-4199-94a2-2a2891ae7a19"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("6fe83343-91c9-40e7-bd21-c4ea9d636a7a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7182f252-b652-4769-8f26-347f5e9c2b2d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("75651fbc-3708-4cc1-9835-e4086cd854f9"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7a3d3da6-5eee-4c74-b3d5-e225acc930a5"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7a96c37b-c282-4ca2-b332-eee5612c7617"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7c23e599-50b4-4fb0-8c27-b23da4fff122"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("7fdecfff-3b93-4ecc-b67c-44e649c25923"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8215386b-e6cc-47c9-897e-ddc7215c79e2"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("82286ee3-de75-4bfe-a6de-ebc75669ff7d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8b04510d-303f-4312-9ee6-cfd194573805"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("8cbf4ed2-cd25-40d6-a537-ba1b74aa46b0"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("90abade9-7e84-406a-a32a-5b04421e583d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("93915c58-f78e-4c54-8270-3d8352dab449"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("977b163a-2cac-4692-9056-4e789c22357f"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("97c01b3a-c65d-4064-96ac-52c634552b0b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("9cd597a8-27e4-4356-91c7-a262cf6e82f8"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("a202dce9-84a1-4afc-a83d-64c315912c04"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("a78d4eef-5c5b-4558-8237-b37eee92b057"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("a8c15d5b-8744-4284-b916-fc3d425fa0b7"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("ac87bebf-2899-4ae5-b8e4-792adb8ab006"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("af95369c-bbf2-4475-aa06-83532aaa0feb"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b06f4dd4-067f-474d-a765-709d3a201d0b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("b735d9a6-e8bd-4ad4-ab09-12c92bb0d7af"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("ba685c20-25a8-47f3-8a93-cbe70af8b84f"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("bf5babc9-c6ae-4026-8451-aaee1bcc7688"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("c328663f-d29f-4e45-baa7-67ceb4432de7"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("c53735b1-b1d3-4980-ba31-00852f4b188e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("c6f8a342-4e92-4c47-896b-37e606d030ba"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("c7996b7f-7c8a-4b86-a649-27e2b9725bbf"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("ce65549b-0d1e-4a5a-9f0f-92122ac62bea"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("cfbfac8e-211b-4a24-a5d9-398d63152c6a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d64927b8-0796-4bca-8e5d-b6198c9ca7fe"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d80b35d5-7152-4bda-8d71-e844a295c355"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d820ff6b-5563-464e-9399-03b2fd0d8083"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d93fdd1a-1dfc-4fe2-8730-3139e36d215d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d9819f41-94dc-4094-846d-d18393d5ce5a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("d9ac239f-afc3-4d13-9101-c71fe703005a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("dbb1e519-cc93-49eb-b32e-0666d7fadb2b"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("dd917ade-9d79-4dfd-8789-0d6a0e682a31"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("e27840db-375a-453a-b4f8-e49a67ff2bdd"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("e6812657-b7b6-41de-9615-f482b89d322e"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("e8797d8f-70d6-49a3-9d9a-9747e9ab91ac"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("ed46a2d8-b6f1-49b1-ae45-263cb04537d7"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("eff4e6d2-e238-4f1b-bde8-24c140ed7905"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f00b2fce-f35c-464d-9461-9ed375f8035d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f16d7024-1fac-46af-a369-7b121acb7c9d"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f3ee49f7-aa8d-4380-97a6-e73f84466960"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f486dc1c-f508-468c-b7ba-94fd092ae60a"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("f63a9d44-30f4-4ed7-b807-030df61c7929"));

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "StandId",
                keyValue: new Guid("fb022792-c57b-4a8e-b1df-841fec6c6345"));

            migrationBuilder.DeleteData(
                table: "Uhs",
                keyColumn: "ID",
                keyValue: new Guid("81cfd799-1cb5-4852-8123-845ae6da4404"));

            migrationBuilder.DropColumn(
                name: "DepartamentoID",
                table: "Colaborador");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAdmissao",
                table: "Colaborador",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Colaborador",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FormacaoConcluida",
                columns: table => new
                {
                    FCID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColaboradorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAcao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFimAcao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacaoConcluida", x => x.FCID);
                });

            migrationBuilder.CreateTable(
                name: "Justificacoes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Justificacoes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UhID = table.Column<int>(type: "int", nullable: false),
                    UhID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaID);
                    table.ForeignKey(
                        name: "FK_Salas_Uhs_UhID1",
                        column: x => x.UhID1,
                        principalTable: "Uhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Justificacoes",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Nome" },
                values: new object[,]
                {
                    { new Guid("72c36203-f875-44e1-8536-c55b0c8980f5"), null, null, null, null, "ATRASO" },
                    { new Guid("0267e756-9520-4c13-8ff9-33c2232605f9"), null, null, null, null, "ACIDENTE DE TRABALHO" },
                    { new Guid("77f61289-8ea8-4862-bc5d-b19093636140"), null, null, null, null, "INCUMPRIMENTO NOTIFICADA" },
                    { new Guid("b8884316-1b76-4fcc-a217-d4f855254837"), null, null, null, null, "INCUMPRIMENTO NÃO NOTIFICADA" }
                });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("b7e056b3-6f95-4758-8d20-c11a205f8ef0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47A", 16, true, false, true },
                    { new Guid("91d5377a-0ae4-40f1-b360-b6fb3a4b320c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47", 16, false, false, true },
                    { new Guid("e5aa88f5-9358-418a-8143-85a0f7f143bf"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46A", 17, true, false, true },
                    { new Guid("c52f257a-5edf-4032-acfb-27cd3932a5aa"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46", 17, false, false, true },
                    { new Guid("3249e790-aa36-4257-92cf-6e03e190255e"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45A", 16, true, false, true },
                    { new Guid("6270e3ca-c0f6-49ea-a859-f92003dd0c2c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45", 16, false, false, true },
                    { new Guid("edacd1fd-032f-4a2f-aa38-afe0169a495f"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44A", 15, true, false, true },
                    { new Guid("e68f328d-fd8c-4650-b4ad-be83a41f4520"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "201", 10, true, true, false },
                    { new Guid("bd04535a-e075-4e90-8ac1-64e14fec2159"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44", 15, false, false, true },
                    { new Guid("8e3c1dc8-0b0f-4845-8602-0978157c06b9"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43B", 14, true, false, true },
                    { new Guid("74d89aaf-9f0b-4160-8763-5794abf0ea97"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43A", 14, true, false, true },
                    { new Guid("0fbef165-cf17-4556-81f2-ff4921c5ceab"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43", 14, false, false, true },
                    { new Guid("af5e473d-5b7f-493c-91ab-391bb44e4f25"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44B", 15, true, false, true },
                    { new Guid("9d91c221-1c82-4c85-ba58-24c08cbed6e8"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "202", 10, true, true, false },
                    { new Guid("6ca10b2d-17d5-4adf-8a4c-aa152f527b7e"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "204", 10, true, true, false },
                    { new Guid("769c7105-8ec4-452b-a515-3e486baffc36"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42A", 13, true, false, true },
                    { new Guid("e1568890-8201-499e-8bcd-5d4ebe71b142"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "206", 10, true, true, false },
                    { new Guid("951b155a-efff-44e2-b838-31f82e4f8e7f"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "207", 10, true, true, false },
                    { new Guid("f037f2f0-0136-49d7-a90f-56bb0d14a369"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "208", 10, true, true, false },
                    { new Guid("2fed30c4-a929-494c-be60-cc1349e73700"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209", 10, true, true, false },
                    { new Guid("86834510-9eb0-4fec-ab7c-0c3be5bd97c5"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209A", 10, true, true, false },
                    { new Guid("b8fffb68-6247-4a8f-8f83-91ea666684ae"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "210", 10, true, false, false },
                    { new Guid("1ce714d5-05f6-45b7-b041-c3ddba65e76a"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211", 10, true, false, false },
                    { new Guid("0f8ac595-8519-481c-b344-0725614ab726"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211A", 10, true, false, false },
                    { new Guid("2dadf1d5-d924-40d9-a504-880b1d476f50"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212", 10, true, false, false },
                    { new Guid("710c59c5-842a-4684-a9ac-1faf9ec41c9f"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212A", 10, true, false, false },
                    { new Guid("d41cb7fc-5327-4741-931d-33a3d20c18de"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214", 10, true, false, false },
                    { new Guid("9045da3d-fcf8-41d2-8fd6-0ac38a906df1"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214A", 10, true, false, false },
                    { new Guid("130e0344-aea1-4e62-be2e-b88ae5a6d798"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "203", 10, true, true, false },
                    { new Guid("70457970-acd6-4b78-aeeb-08be4d587f5a"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42", 13, false, false, true },
                    { new Guid("34c1c21c-641f-4e23-8c59-0fff42a2c5bc"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "205", 10, true, true, false },
                    { new Guid("149f15d5-fa7f-43a9-8a85-8b95228510b0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41", 13, false, false, true },
                    { new Guid("7cc31793-4136-4a15-8cc9-f1d4e7e3845d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41A", 13, true, false, true },
                    { new Guid("75b75d72-5c5a-4182-b9da-b4932f5b2138"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "07", 12, false, true, true },
                    { new Guid("3b783982-e915-49a8-a732-f5e8590cfe98"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "08", 12, true, true, true },
                    { new Guid("c49f4cd9-9b67-467e-be0e-40c9eb6cb1b7"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "8B", 12, true, true, true },
                    { new Guid("859111f2-24d7-479f-99a7-b24bf0fdcaae"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "09", 11, true, true, true },
                    { new Guid("a41ad9c4-3baa-4e57-b56e-6e3c26d94716"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "10", 11, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("fef07bef-eb16-4426-b284-cb747d6789a9"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "12", 10, true, true, true },
                    { new Guid("bdd77293-241a-40a2-9137-fcb6049326e4"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "13", 9, true, true, true },
                    { new Guid("7f62bef3-60bb-4f92-bb27-03c0d05d80ad"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "14", 9, false, true, true },
                    { new Guid("98f9892d-b914-4850-b95a-07b21ca72e82"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15", 8, false, true, true },
                    { new Guid("d6d1ebab-b219-4333-9afa-fa24eb0e60b3"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15A", 8, true, true, true },
                    { new Guid("1260c1f1-cd4b-4456-9817-038efb01ee88"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16", 8, false, true, true },
                    { new Guid("44ebca02-6308-4263-8df3-f877c54e1287"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16A", 8, true, true, true },
                    { new Guid("72ae58e7-d855-478a-9659-6d71662f21c3"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17", 7, false, true, true },
                    { new Guid("a2d69fc9-3596-4f21-a5cc-368dbd055aa4"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "11", 10, true, true, true },
                    { new Guid("940d1d2f-9c04-4f45-8331-9de7426165de"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18", 7, true, true, true },
                    { new Guid("f25ec45f-91f5-46c4-8048-b20d4bbdc24b"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "27", 12, true, false, true },
                    { new Guid("fc007a64-ce8e-4d7f-ad2a-e3825cda1575"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17A", 7, true, true, true },
                    { new Guid("17161fda-268f-443e-8191-765b836c2f0b"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "26", 12, false, false, true },
                    { new Guid("a3b13068-1867-49e7-85ed-69358f4cf338"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "25", 7, false, true, true },
                    { new Guid("e171f1e1-e4a8-4f2e-bba8-a689631c95ca"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23A", 5, true, true, true },
                    { new Guid("cad9278f-fac7-46b2-ae30-40fea89aae74"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23", 5, false, true, true },
                    { new Guid("3066ba72-b901-4ca8-a5ce-35838877e260"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22A", 5, true, true, true },
                    { new Guid("03a1fab5-4643-4b17-b2eb-520b8fc36296"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "24", 7, false, true, true },
                    { new Guid("e3cafd63-72fb-4583-b24a-2ead1549aea5"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "21", 6, true, true, true },
                    { new Guid("9caf61d2-8605-4d96-8f4f-418e2cad5605"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "20", 8, true, true, true },
                    { new Guid("4cc927f2-b479-4452-bfa6-f5b11f93ee3d"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "19", 8, true, true, true },
                    { new Guid("fbaf5ba5-8fd8-4ff2-88fa-8f57a5b0a9a7"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18B", 7, true, true, true },
                    { new Guid("fb90f70a-85f9-498a-8a55-1ae3654d91bc"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22", 5, false, true, true },
                    { new Guid("ecb2042b-90cf-466a-856c-d3f110d0b4bf"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18A", 7, true, true, true }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "8de4f4a9-3f13-4e34-9892-44b82b0a8b31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "8540758c-46c7-46a8-a982-77579ba57c25");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "d98e0954-c0a2-477a-b9c3-efb1cb9496a4");

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("2a8a789c-f8f8-46b9-be44-8a7483d287d3"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 505 },
                    { new Guid("71743bbf-d61d-4782-96e4-a88290441231"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 426 },
                    { new Guid("749e4ed6-6e90-4f0e-9d6a-75e7080975f4"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 501 },
                    { new Guid("1bda327a-b137-414c-9500-3ba683be5d1b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 506 },
                    { new Guid("e3b865b4-6083-4c2d-8e36-e0e5a9533328"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 503 },
                    { new Guid("6cc9a02c-01da-4997-8af1-07e366626634"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 504 },
                    { new Guid("48be98f3-d900-4d1e-972b-9605c86e2053"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 502 },
                    { new Guid("b8e39f1a-bb36-4356-8832-75a5bc997ab8"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 425 },
                    { new Guid("5fd29953-bf2e-4784-90d7-599c22b4d1ea"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 414 },
                    { new Guid("78aed538-36b6-473d-9ebd-492c69176ac7"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 423 },
                    { new Guid("5db0a72a-3381-4f43-a6ff-d1b11870bcc8"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 422 },
                    { new Guid("2271a327-6e36-49a9-ad3b-9b4fac627967"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 421 },
                    { new Guid("09f886a8-b7ed-483b-9108-9a15588c1bc5"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 416 },
                    { new Guid("8fd5e382-68e0-4170-ba0c-8585e7540d79"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 415 },
                    { new Guid("599fe2c6-a923-4f7f-ac75-e7339e3a9abd"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 601 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("01017935-35bb-4c19-ab19-5efcd37e8d77"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 413 },
                    { new Guid("7d931b73-112c-42ad-bfbb-a33b69f9eb07"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 424 },
                    { new Guid("7a86b496-7211-41d3-a319-b8669feab78e"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 602 },
                    { new Guid("127f70c7-fb15-4781-a733-9167f1fc9555"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 803 },
                    { new Guid("91237d37-9362-4932-8960-97f195191a8b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 604 },
                    { new Guid("f0f5ddfd-d61f-4311-8f30-6ed8709843c9"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 412 },
                    { new Guid("06f00af9-e496-4738-99b5-5616ef8d9f0a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 806 },
                    { new Guid("95361bfd-c682-42c4-8396-5c09bd74addc"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 805 },
                    { new Guid("efcb6290-ca82-401d-915f-04219a4d2d0a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 804 },
                    { new Guid("58c803ec-b007-4364-a28a-f78a521ef304"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 802 },
                    { new Guid("efda688c-bf72-4d84-b479-b07b6a744681"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 801 },
                    { new Guid("7c107e84-e44f-4d4b-a091-d437f3b31f36"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 706 },
                    { new Guid("842356e2-eea5-4f18-b91f-26e10aabde7e"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 705 },
                    { new Guid("a9dfe146-6e02-4baa-817e-9768d4a59b6d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 704 },
                    { new Guid("7df823b8-35b2-4e18-9cf8-9a709baa2ce4"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 703 },
                    { new Guid("14be9c74-66e9-40a9-9881-e9c12ddc2dcb"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 702 },
                    { new Guid("8f95f9e1-eedb-4060-928d-8b757ef18a84"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 701 },
                    { new Guid("17ed82ab-41d9-4fed-b6e7-15a323f8dada"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 609 },
                    { new Guid("2cc44d5b-ca28-4e41-9f98-7d63c2eeaac5"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 608 },
                    { new Guid("86279fd1-beb7-4911-981b-573167eb6ee5"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 607 },
                    { new Guid("acf8a358-30e4-4d2b-aeaf-70c10ef3cc7a"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 606 },
                    { new Guid("e8e69e70-ca8c-4e94-a2af-5033b50154aa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 605 },
                    { new Guid("15a3f7c5-7a0e-4c7a-8a6f-73c506ee88ad"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 603 },
                    { new Guid("6638cea8-3eee-4e20-8921-f97c2e0a6b42"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 411 },
                    { new Guid("849ccd7d-b65c-4f43-8c37-191b237b8a07"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 122 },
                    { new Guid("6892bd55-44e4-48f7-a011-3f1d5778776f"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 404 },
                    { new Guid("d0dff326-d21d-4b8c-9212-bc8f9fa512ff"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 145 },
                    { new Guid("b8e83dd3-e47f-4e77-ab40-64d7d1eb2df4"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 144 },
                    { new Guid("79cdbdab-c435-4925-b551-b7599845c8b2"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 143 },
                    { new Guid("421d9711-c2fe-414a-8ec6-9bf4c28b6ad2"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 142 },
                    { new Guid("72649504-7c95-4b6c-9336-8449779d0c4d"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 141 },
                    { new Guid("5648c64f-d93f-4fcd-bc21-c6f45dd89f84"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 126 },
                    { new Guid("1c80b975-74df-4de9-ab85-75269963fe8f"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 125 },
                    { new Guid("42814768-bda1-4537-82ce-233d9a651239"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 124 },
                    { new Guid("9af9a9ad-25a3-4050-96b5-5fd39a039f89"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 146 },
                    { new Guid("532fb788-8e5a-4336-80b8-b4a139a64fed"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 123 },
                    { new Guid("9cddf05e-6547-4a46-80ae-ecf6931f1515"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 116 },
                    { new Guid("9647ffb2-e4e0-48c6-9911-14f20a5477d4"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 115 },
                    { new Guid("555aff86-3c88-47a1-ad9c-963ae36f31d4"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 114 },
                    { new Guid("f31d41bf-e261-4074-bf9f-8857026d9fb2"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 108 },
                    { new Guid("34f27809-fdb9-48b4-b6f6-eec47bef3e57"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 107 },
                    { new Guid("66e88b53-defc-42e9-949f-adf4a691865e"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 106 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("5676f225-45d5-438a-9e14-e94524e2fba0"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 105 },
                    { new Guid("9ee07069-cca4-4350-acfa-1cd8a3811807"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 104 },
                    { new Guid("4400e4fc-3468-44cd-bfe7-3d8f04e03f01"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 117 },
                    { new Guid("02dcf2b6-8ed6-42f4-9769-d9d5cbd088ac"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 405 },
                    { new Guid("8a80edf7-5fa8-4b72-a7ce-871b8b87e596"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 147 },
                    { new Guid("1c59ac04-d166-4605-b32e-0acd9d175f16"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 201 },
                    { new Guid("f2ef57c3-6a81-4890-a732-da2f3efb4389"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 403 },
                    { new Guid("836a4883-c015-469d-b6a2-2108fd6f838c"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 402 },
                    { new Guid("d8753ce2-bbbd-4990-a6d9-3ccff77f4449"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 401 },
                    { new Guid("5f83ac5e-6ca5-4aa4-a243-de44b797b74e"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 302 },
                    { new Guid("5ae15ea1-12b6-40e3-b59b-261eb3efd136"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 301 },
                    { new Guid("9fc21a6a-5ba2-422e-ae7e-94aa51aaa921"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 225 },
                    { new Guid("c58d3406-d98f-4db1-acf6-28cb8b1485a8"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 224 },
                    { new Guid("9c6e35f6-b727-4e8f-b2c5-1cef21e4488d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 223 },
                    { new Guid("b1cec3ad-5009-4011-9d71-a3b0bfa5ded2"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 200 },
                    { new Guid("80563d90-44d8-4dae-93f4-5f775fac5177"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 222 },
                    { new Guid("11e7de6d-43cb-4e4f-8ad8-e4a93cfc625b"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 209 },
                    { new Guid("ad49e988-a53d-4fe2-bde8-ee013e25ac6c"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 208 },
                    { new Guid("51c745b4-ea45-4568-a681-a2a9bb2c1124"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 207 },
                    { new Guid("dbe64307-0d49-4c99-b0b1-c214ce942952"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 206 },
                    { new Guid("fb72d15b-0695-4d17-9ab3-d7f2108ac333"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 205 },
                    { new Guid("d3e33ecb-2e0b-49b7-b02b-26bff1e0f889"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 204 },
                    { new Guid("b5453618-deae-4fc6-97b7-9f1ca78435bc"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 203 },
                    { new Guid("46deaef9-0ccc-431a-9f92-63591ae966c4"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 202 },
                    { new Guid("51fd905e-bbe4-4ad9-b48b-a16ce2a99f4c"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 221 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59cb4979-052f-4b66-92be-91c6d60620cf", "AQAAAAEAACcQAAAAEE79j9Xz424UM301mrIRxHWl7JPvwSXj+dDwGJrXNZNdKyqHYVOUKm+J+AQK6zfbmw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Salas_UhID1",
                table: "Salas",
                column: "UhID1");
        }
    }
}
