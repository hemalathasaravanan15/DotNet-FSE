import React from 'react';

const blogs = [
  {
    title: "React Learning",
    author: "Stephen",
    content: "Welcome to learning React!"
  },
  {
    title: "Installation",
    author: "Nicholas",
    content: "You can install React from npm."
  }
];

const BlogDetails = () => (
  <div>
    <h2>Blog Details</h2>
    {blogs.map((blog, index) => (
      <div key={index}>
        <strong>{blog.title}</strong>
        <p><b>{blog.author}</b></p>
        <p>{blog.content}</p>
      </div>
    ))}
  </div>
);

export default BlogDetails;
