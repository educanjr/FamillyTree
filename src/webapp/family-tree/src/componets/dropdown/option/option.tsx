import styles from './option.module.css';

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
    children: React.ReactNode;
    isSelected: boolean;
}

export default function Option({ children, isSelected = false, ...props }: ButtonProps) {
    return (
        <button className={`${styles['dropdown-option']} ${isSelected ? styles['selected'] : ''}`} {...props}>
            {children}
        </button>
    );
}