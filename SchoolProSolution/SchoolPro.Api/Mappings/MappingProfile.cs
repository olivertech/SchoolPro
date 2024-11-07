namespace SchoolPro.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /**
             * Mapping Requests ( Request -> Model )
             */
            CreateMap<UserRequest, User>();

            /**
             * Mapping Responses ( Response <- Model )
             */
            CreateMap<User, LoginResponse>();
            CreateMap<Role, RoleResponse>();
            CreateMap<AccessToken, AccessTokenResponse>();
            CreateMap<School, SchoolResponse>();
        }
    }
}
