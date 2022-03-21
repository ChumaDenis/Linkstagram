import React, { useState } from "react";

import axios from 'axios';

interface IPost {
    "username": string,
    "login": string,
    "password": string
}

const defaultPosts:IPost[] = [
    {
        "username": "username",
        "login": "user@example.com",
        "password": "password"
    }
];

function CreateAccount(){
    const [posts, setPosts]: [IPost[], (posts: IPost[]) => void] = React.useState(defaultPosts);
    const [loading, setLoading]: [boolean, (loading: boolean) => void] = React.useState<boolean>(true);
    const [error, setError]: [string, (error: string) => void] = React.useState("");

    React.useEffect(() => {
        axios
            .get<IPost[]>("https://linkstagram-api.linkupst.com/create-account", {
                headers: {
                    "Accept": "application/json",
                    "Content-Type": "application/json",
                }
            })
            .then(response => {
                setPosts(response.data);
                setLoading(false);
                console.log(response);
            })
            .catch(ex => {
                const error =
                    ex.response.status === 404
                        ? "Resource Not found"
                        : ex.response.status;
                setError(error);
                setLoading(false);
            });
    }, []);

    return (
        <div className="App">
            <ul className="posts">
                {posts.map((post) => (
                    <li key={post.username}>
                        <h3>{post.login}</h3>
                        <p>{post.password}</p>
                    </li>
                ))}
            </ul>
            {error && <p className="error">{error}</p>}
        </div>
    );
}
export default CreateAccount;