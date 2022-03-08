import React from "react";
import { Routes, Route, Link } from "react-router-dom";

import "../../../Index.css"
import HomePage from "../../pages/home";
import ProfilePage from "../../pages/profile";
export function Router() {
    return (
        <div>
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/about" element={<ProfilePage />} />
            </Routes>
        </div>
    );
}