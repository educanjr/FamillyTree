'use client'

import { useRouter } from "next/navigation";
import NavigationButton from "@/componets/navigation-button/navigation-button";

export default function GoHome() {
    
    const router = useRouter();
    
    const handleRouter = () => {
        router.push('/');
    }

    return (
        <NavigationButton isActive label='Go back' onClick={handleRouter} />
    );
}