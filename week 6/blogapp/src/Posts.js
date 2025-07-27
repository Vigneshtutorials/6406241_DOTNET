import React from "react";
import Post from "./Post"; // your model

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
    };
  }

  loadPosts = async () => {
    const response = await fetch("https://jsonplaceholder.typicode.com/posts");
    const data = await response.json();

    const formattedPosts = data.map(
      (item) => new Post(item.id, item.title, item.body)
    );

    this.setState({ posts: formattedPosts });
  };

  componentDidMount() {
    this.loadPosts();
  }

  render() {
    return (
      <div>
        <h1>Blog Posts</h1>
        {this.state.posts.map((post) => (
          <div key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
            <hr />
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
