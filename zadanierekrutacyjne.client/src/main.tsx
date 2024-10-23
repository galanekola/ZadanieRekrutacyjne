
import App from './App.tsx'
import ReactDOM from 'react-dom/client';
import {
    BrowserRouter,
    Routes,
    Route,
} from 'react-router-dom';
import './index.css'

// @ts-ignore
ReactDOM.createRoot(document.getElementById('root')).render(
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<App  />} />
            </Routes>
        </BrowserRouter>
    
);
