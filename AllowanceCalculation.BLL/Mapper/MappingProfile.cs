namespace AllowanceCalculation.BLL.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Group, GroupModel>().ReverseMap();
		CreateMap<GroupSubject, GroupSubjectModel>().ReverseMap();
		CreateMap<StudentGrade, StudentGradeModel>().ReverseMap();
		CreateMap<Student, StudentModel>().ReverseMap();
		CreateMap<Subject, SubjectModel>().ReverseMap();
	}
}