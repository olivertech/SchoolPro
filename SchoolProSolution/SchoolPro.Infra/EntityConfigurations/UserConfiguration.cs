namespace SchoolPro.Infra.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Common columns
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasValueGenerator<GuidValueGenerator>();
            builder.Property(x => x.IsActive).HasColumnName("is_active").IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasColumnName("created_at").IsRequired();
            builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
            builder.Property(x => x.DeletedAt).HasColumnName("deleted_at");

            //Entity columns
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PicturePath).HasColumnName("picture_path").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.SchoolId).HasColumnName("school_id").IsRequired();
            builder.Property(x => x.AccessTokenId).HasColumnName("access_token_id").IsRequired(false);
            builder.Property(x => x.RoleId).HasColumnName("role_id").IsRequired();

            builder.ToTable("User");

            //Global filter
            builder.HasQueryFilter(x => x.IsActive);

            builder.HasData(new[]
            {
                //=======================================================================================================
                //SEED DO BANCO DE CONFIGURAÇÃO - ESSE SEED É FIXO E NÃO DEVE SER REMOVIDO
                //O SISTEMA CONTA COM UM STARTUP DE DADOS, QUE CONTERÁ INICIALMENTE UM CONTAINER ATIVO DE CONFIGURAÇÕES
                //QUE VAI SER RESPONSÁVEL POR MANTER E GERIR TODO O RESTO DA APLICAÇÃO, MANTENDO ENTIDADES GLOBAIS
                //QUE ARMAZENAM DADOS RELACIONADOS A GESTÃO DE TODOS OS CLIENTES, SEM MANTER AQUI OS DADOS DOS CLIENTES
                //QUE FICARÃO RESTRITOS AOS CONTAINERS DE CADA CLIENTE
                //=======================================================================================================
                new User
                {
                    Id = Guid.Parse("9a150059-614b-47c3-b56f-59deededd8d6"),
                    Name = "Marcelo de Oliveira",
                    Email = "marcelo@schoolpro.com",
                    Password = "123",
                    IsActive = true,
                    SchoolId = Guid.Parse("9cf0bfd2-3d70-11ef-a3ab-0242ac1c0002"),
                    RoleId = Guid.Parse("45533ff6-3ba5-11ef-9476-0242ac130002"),
                    CreatedAt = DateOnly.FromDateTime(DateTime.Now)
                },
            });
        }
    }
}
