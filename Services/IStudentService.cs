﻿using StudentManagementAPI.Dtos;

namespace StudentManagementAPI.Services
{
    public interface IStudentService
    {
        List<StudentDetailsDto> GetAll();
        List<StudentDto> GetStudentDetails();
        StudentDetailsDto Get(int id);
        void Insert(CreateUpdateStudentDto studentDto); // 
        void Update(CreateUpdateStudentDto student,int id);
        void Delete(int id);
    }
}
