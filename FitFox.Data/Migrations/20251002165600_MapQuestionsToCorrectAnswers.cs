using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFox.Data.Migrations
{
    /// <inheritdoc />
    public partial class MapQuestionsToCorrectAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"),
                column: "CorrectAnswerId",
                value: new Guid("6db1e63d-9c8d-42a1-975a-2e4c91f55f2d"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"),
                column: "CorrectAnswerId",
                value: new Guid("e15973be-d5b9-4db0-8a25-8fbcb18d80cf"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"),
                column: "CorrectAnswerId",
                value: new Guid("d1a2e87a-fbc1-47e0-9c0d-7fc3b5adad3b"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"),
                column: "CorrectAnswerId",
                value: new Guid("e8b0b203-90ba-4285-ad9e-493bd3592135"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"),
                column: "CorrectAnswerId",
                value: new Guid("3d4e27ab-2849-4260-9788-0a6d80e2b70c"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"),
                column: "CorrectAnswerId",
                value: new Guid("c7f01db0-19b4-4c64-bb64-f87fdf38ff6c"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"),
                column: "CorrectAnswerId",
                value: new Guid("f1db93db-420d-4d91-97a5-760312f0a633"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("27365168-3b26-4638-927a-0a0d32108cd7"),
                column: "CorrectAnswerId",
                value: new Guid("9f6a55dc-d7de-4d67-ae8e-8220700dcd55"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"),
                column: "CorrectAnswerId",
                value: new Guid("f9c02ef8-1ed0-44f0-b057-4b8a4a8e97c1"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"),
                column: "CorrectAnswerId",
                value: new Guid("f0e9d8c7-1b2c-4d3e-9f5a-9b0c1d2e3f4a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"),
                column: "CorrectAnswerId",
                value: new Guid("e0f1a2b3-4d5e-4f6a-8c3d-6d7e8f9a0b1c"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"),
                column: "CorrectAnswerId",
                value: new Guid("9f0c9cf0-c5e6-46f4-9c36-134d962a28f9"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"),
                column: "CorrectAnswerId",
                value: new Guid("f6a5b4c3-7d8e-4f9a-8b1c-5d6e7f8a9b0c"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"),
                column: "CorrectAnswerId",
                value: new Guid("f4e3d2c1-5b6c-4d8e-9f9d-3f4a5b6c7d8e"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"),
                column: "CorrectAnswerId",
                value: new Guid("ace71c5c-f9f3-49cc-b229-5d54f46f04d0"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"),
                column: "CorrectAnswerId",
                value: new Guid("4f1c3b7c-b8a9-4cbf-9a69-27b6e12a2bb0"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"),
                column: "CorrectAnswerId",
                value: new Guid("8d329f9a-9073-467c-8bb8-7748d7276bb3"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"),
                column: "CorrectAnswerId",
                value: new Guid("f1b2d3a4-5e6c-4f8d-9a1b-2c3d4e5f6a7b"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"),
                column: "CorrectAnswerId",
                value: new Guid("742c20f9-e86b-42f5-b4ea-8570e33c72e9"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"),
                column: "CorrectAnswerId",
                value: new Guid("9d52f7a2-3538-4d07-b633-08c9334504e8"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"),
                column: "CorrectAnswerId",
                value: new Guid("7c66cb38-1a4c-4c36-9b8a-f0a632cd208f"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"),
                column: "CorrectAnswerId",
                value: new Guid("b8f7d3c4-1a5b-4e8c-9d2a-0f4e3c7b2d1a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"),
                column: "CorrectAnswerId",
                value: new Guid("7d8f3079-46dc-4a3f-a69d-5ad1a7bbf79a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"),
                column: "CorrectAnswerId",
                value: new Guid("c4d9784f-7d60-4fdc-858a-71af0a3f3a18"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6aea4f8b-3785-4027-8532-6592c9436898"),
                column: "CorrectAnswerId",
                value: new Guid("de739138-256a-4f36-8c38-d3e69a8a0f8e"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6c611141-34e9-4ae5-892c-27106d39782d"),
                column: "CorrectAnswerId",
                value: new Guid("3b7ec122-1ed4-408f-a60c-23d1de8ccf9f"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"),
                column: "CorrectAnswerId",
                value: new Guid("47836262-2b8f-42d3-a92c-9c07f87ecf0a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"),
                column: "CorrectAnswerId",
                value: new Guid("6b3c55d0-3ec7-4b8c-bc36-9b1c6ac8d3f6"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"),
                column: "CorrectAnswerId",
                value: new Guid("3c3fd6c5-5c2d-4ef4-b2a3-fdf7f4d7dc94"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"),
                column: "CorrectAnswerId",
                value: new Guid("86922f5c-4f7f-43d7-81c0-08f697e8fc6d"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"),
                column: "CorrectAnswerId",
                value: new Guid("a07312e1-9b6c-46c4-90bb-49c1386e9122"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"),
                column: "CorrectAnswerId",
                value: new Guid("8c5dcaaa-96a0-4267-9eb6-b94ec78e0f7a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"),
                column: "CorrectAnswerId",
                value: new Guid("9f87c20a-60c0-4c3a-8b8c-9abbeed8f761"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"),
                column: "CorrectAnswerId",
                value: new Guid("be0f259c-c282-4c5c-bf45-27d9d7468f7d"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("99e612f3-3e52-4616-8ea1-19d620463779"),
                column: "CorrectAnswerId",
                value: new Guid("7336f137-8ef5-40d5-9a59-515889f0bb05"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"),
                column: "CorrectAnswerId",
                value: new Guid("8233a9f1-cfd0-44d7-a16a-8a993f41c292"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"),
                column: "CorrectAnswerId",
                value: new Guid("0f9d15b7-8b2f-4df7-8613-93d80d3d3c34"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"),
                column: "CorrectAnswerId",
                value: new Guid("7354444b-3ba1-4ce6-a684-37d5626ab44b"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"),
                column: "CorrectAnswerId",
                value: new Guid("f3c7b58d-8fbb-4d6e-b2f5-3e6f2d9a7b21"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"),
                column: "CorrectAnswerId",
                value: new Guid("bbbf52d1-d379-4b59-a63f-38b611897b93"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"),
                column: "CorrectAnswerId",
                value: new Guid("aef3c9d5-9e37-45d2-9ec0-b9e2d9c16e60"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b850b9da-babb-465e-96b4-99639f04711e"),
                column: "CorrectAnswerId",
                value: new Guid("b7c8d9e0-1a2b-4c3d-9f4e-3a5b6c7d8e9f"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"),
                column: "CorrectAnswerId",
                value: new Guid("5b1d3a91-2d5f-44cb-8e0d-3904a04d3a3d"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"),
                column: "CorrectAnswerId",
                value: new Guid("a8e4f0c5-5a2c-4e2e-98d1-0f7bfa36c1b7"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"),
                column: "CorrectAnswerId",
                value: new Guid("6c44c89a-c257-4cd5-8653-c3f523b42f15"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"),
                column: "CorrectAnswerId",
                value: new Guid("b3c4d5e6-7f8a-4d9b-9d6e-9a0b1c2d3e4f"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"),
                column: "CorrectAnswerId",
                value: new Guid("99ed08ac-d2f2-4696-9cfa-471f89e6e1ae"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d3207231-b15e-428f-b6e7-ab53471202af"),
                column: "CorrectAnswerId",
                value: new Guid("96dfaf70-57dc-4210-99e5-f3b7dc9d8415"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"),
                column: "CorrectAnswerId",
                value: new Guid("d0c6a5e2-3c2b-4f85-8ed2-1a9b6c7d4f2a"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"),
                column: "CorrectAnswerId",
                value: new Guid("f83a6d41-2405-4c38-8b64-546e61d8c6fc"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"),
                column: "CorrectAnswerId",
                value: new Guid("4e32c960-39e4-4fd0-87c1-6b5645d1a0f2"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"),
                column: "CorrectAnswerId",
                value: new Guid("e6f7a8b9-0c1d-4d2e-8a9b-2d3e4f5a6b7c"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"),
                column: "CorrectAnswerId",
                value: new Guid("5ec2107b-82eb-4721-bbbc-62aa5d1af6c3"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"),
                column: "CorrectAnswerId",
                value: new Guid("c3b1f8a4-2d7e-4b9c-9a1f-0b6d3e5f7a1b"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"),
                column: "CorrectAnswerId",
                value: new Guid("ed8fd22a-57e2-42d5-8238-7e6ef1537f12"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"),
                column: "CorrectAnswerId",
                value: new Guid("f88a1ed1-8d71-4d61-a0bb-d91e9b3d0c3f"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"),
                column: "CorrectAnswerId",
                value: new Guid("8e154d3b-1f8b-4ef4-85a5-3014f5ea31c2"));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"),
                column: "CorrectAnswerId",
                value: new Guid("6222fac1-7b03-4910-a689-7389b679e51b"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("018a8f7d-e12b-49d5-8718-889aa668cafb"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04ecf251-b526-4445-a6f6-a6c7dfdd586a"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b831d70-b6e1-4eb6-8c5a-ac03c7d5d62f"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ef6cf36-8764-4924-9b01-5fcc247c96aa"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1020c72c-9f20-4b04-8523-e2a9dc643ed2"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("196f6df9-6234-499b-9309-c6b0cd29e349"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e3c972d-3549-4d00-8ca5-88ac510abe63"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("27365168-3b26-4638-927a-0a0d32108cd7"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2ca88517-a1ad-4bc9-9283-0e4100d60dcd"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2cd2b95d-63c0-4c7f-9485-3df385a91476"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34c91eb1-1e3b-4f7b-bf02-8b9f34653023"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("39d43280-d51f-4a8e-921f-97b6f4b2873e"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3b1a72e5-e73e-4e8d-833e-b92a61eb2664"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3bbce0fb-8e12-4a03-837d-9ac269f282ff"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d1a7d0b-029c-41f3-81fd-cb53ff5ed0ea"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3da3629a-ace4-45f2-900b-6c134ba6231b"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4420dd55-0f57-439b-bc4b-47623fe05e5c"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4c550c86-a27f-480d-8a34-26a5d94d7bb3"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fbd5ee9-c603-4530-a325-0b8c94d87e52"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("562c6f2d-4216-4f46-b74b-a764a7ad5418"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("57b4cf97-88e2-4b77-a66a-dfa5704aa3cb"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5ef2fcf6-df7a-4f3d-9958-3d3c20fe9b90"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f83b77f-09eb-43ab-aac6-1ba1a74a8225"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6632e20e-4ff2-4342-8af2-698acaf6e495"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6aea4f8b-3785-4027-8532-6592c9436898"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6c611141-34e9-4ae5-892c-27106d39782d"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d2a72e4-ce9c-4f3b-a2ba-48667f8d6062"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("706cec35-8678-40a3-bf08-3f4a001765e5"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("725ac1b4-5362-484a-964a-4a1bc95a2aab"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("734b09f7-245b-43cf-bf1a-87a2ead54981"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a37747e-9f9c-4d6d-a25a-10ee17d64a09"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8b071bdd-25b1-4ab2-9c64-32e44e2eb889"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8d2dbe17-1c9e-45f7-8fd2-d38f4d7f43ff"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("905e3202-c416-470b-8e11-ce66a9f7a534"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("99e612f3-3e52-4616-8ea1-19d620463779"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9fced86-bd78-4901-b983-f05a2ad96bcd"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ab0fda0c-dca4-4b12-a690-8e1b311ee5de"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("af7f8faf-0b47-43a7-bce0-2120af75c39c"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b4baf54c-59b6-4b9d-91d9-7e3352b5d3ee"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6d72991-5934-4d11-8c64-2144493e4fc6"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b77e9f69-16dc-4192-9c86-cfa9ccf86a5b"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b850b9da-babb-465e-96b4-99639f04711e"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc00cf25-bf28-4994-92ea-34b3c1cf2b8e"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c29ae0bc-eb61-45c1-be09-2e24ca66862b"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c3dc5b10-c49e-4c55-82bf-19588f1ce0a4"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cb1eb27c-eb7a-49f1-bf83-5b89a8dca794"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cbb7907f-d0ab-4b6a-90e2-99312cdf12e4"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d3207231-b15e-428f-b6e7-ab53471202af"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d76f8572-c76d-4ea6-96e2-88f94b2ef5db"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da4b1734-79df-4b91-a69f-7c52b4b7553a"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dce5b4e5-c46d-4b34-b5ae-14e67d6b753e"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddbf95d6-d691-48e2-8c7d-6ce2150e3ac5"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e70a94b3-2a6d-4f7b-8250-9f43c5ac4c72"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e74d6670-97b6-42c9-8464-881dbb6bfa9d"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ed946370-816b-4175-bfee-cc24d3d3c971"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f35e77c4-447c-46f3-893e-62110c2ff969"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f68f4855-4f08-4e5e-9480-497f2e7f70c5"),
                column: "CorrectAnswerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fc987683-272e-4874-9ec0-adbd1d4d43f0"),
                column: "CorrectAnswerId",
                value: null);
        }
    }
}
