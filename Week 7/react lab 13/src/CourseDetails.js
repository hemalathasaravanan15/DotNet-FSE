import React from 'react';

const courses = [
  { title: "Angular", date: "02/08/2025" },
  { title: "React", date: "6/3/2026" }
];

const CourseDetails = () => (
  <div>
    <h2>Course Details</h2>
    {courses.map((course, index) => (
      <div key={index}>
        <strong>{course.title}</strong>
        <p>{course.date}</p>
      </div>
    ))}
  </div>
);

export default CourseDetails;
